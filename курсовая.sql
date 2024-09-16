CREATE USER menedjer WITH PASSWORD 'menedjer123QWE';
GRANT ALL PRIVILEGES ON DATABASE "tekyuchka" TO menedjer;
ALTER USER menedjer WITH SUPERUSER;


CREATE USER kadri WITH PASSWORD 'kadri123QWE';
GRANT ALL PRIVILEGES ON DATABASE "tekyuchka" TO kadri;
ALTER USER kadri WITH SUPERUSER;

create table organizatsia
(
	id_organizatsia serial primary key,
	name_org varchar(40) not null,
	inn bigint check (inn>1000000000 and inn<9999999999),
	adress varchar(40) not null,
	telephone bigint check (telephone>80000000000 and telephone<89999999999),
	fio_ruk varchar(70) not null
);


create table otdel
(
	id_otdel serial primary key,
	nazvanie_otdela varchar (30) not null,
	koll_sotr int not null,
	koll_vak int not null,
	info_v_otdele varchar (30) check (info_v_otdele in ('Открытая', 'ПДН')),
	id_organizatsia int references organizatsia(id_organizatsia)
);

create table rukovoditel
(
	id_ruk serial primary key,
	familia varchar(30) not null,
	imia varchar(30) not null,
	otchectvo varchar(30) not null,
	date_roj date not null,
	obrazovanie varchar(20) check (obrazovanie in('Нет','Среднее','Среднее проф', 'Высшее')),
	pol varchar(15) check (pol in ('Мужчина', 'Женщина')),
	id_otdel int references otdel(id_otdel)
);

create table doljnost 
(
	id_dolj serial primary key,
	nazvanie_doljnosti varchar(30),
	zp int check (zp>19242),
	obrazovanie varchar(20) check (obrazovanie in('Нет','Среднее','Среднее проф', 'Высшее')),
	obiazanosti varchar(500) not null,
	rejim_rab varchar(15) check (rejim_rab in ('День','Ночь'))
);

create table sotrudnik
(
	id_sotr serial primary key,
	familia varchar(30) not null,
	imia varchar(30) not null,
	otchectvo varchar(30) not null,
	date_roj date not null,
	obrazovanie varchar(20) check (obrazovanie in('Нет','Среднее','Среднее проф', 'Высшее')),
	pol varchar(15) check (pol in ('Мужчина', 'Женщина')),
	id_otdel int references otdel(id_otdel),
	id_dolj int references doljnost(id_dolj)
);


create table trud_kniga
(
	id_trud_kniga serial primary key,
	date_priem_yvl date not null,
	flag_yvl int check(flag_yvl>=0 and flag_yvl<=1),
	prejdnie_mesto_rab varchar(100),
	novoe_mesto_rab varchar(100),
	id_ruk int references rukovoditel(id_ruk),
	id_sotr int references sotrudnik(id_sotr) 
);



CREATE OR REPLACE FUNCTION check_koll_vak() RETURNS TRIGGER AS $$
BEGIN
    IF NEW.id_otdel IS NOT NULL THEN
        PERFORM * FROM otdel WHERE id_otdel = NEW.id_otdel AND koll_vak = 0;
        IF FOUND THEN
            RAISE EXCEPTION 'В отделе уже укомплектован состав работников';
        END IF;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


CREATE TRIGGER trg_check_koll_vak_before_insert_sotrudnik
BEFORE INSERT ON sotrudnik
FOR EACH ROW EXECUTE PROCEDURE check_koll_vak();

CREATE TRIGGER trg_check_koll_vak_before_insert_rukovoditel
BEFORE INSERT ON rukovoditel
FOR EACH ROW EXECUTE PROCEDURE check_koll_vak();


CREATE OR REPLACE FUNCTION increment_koll_vak() RETURNS TRIGGER AS $$
DECLARE
    v_id_otdel INT;
BEGIN
    IF NEW.flag_yvl = 1 THEN
        SELECT id_otdel INTO v_id_otdel FROM (
            SELECT id_otdel FROM sotrudnik WHERE id_sotr = NEW.id_sotr UNION ALL
            SELECT id_otdel FROM rukovoditel WHERE id_ruk = NEW.id_ruk
        ) subquery LIMIT 1;

        IF FOUND THEN
            UPDATE otdel SET koll_vak = koll_vak + 1 WHERE id_otdel = v_id_otdel;
        END IF;
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trg_increment_koll_vak_after_insert
AFTER INSERT ON trud_kniga
FOR EACH ROW WHEN (NEW.flag_yvl = 1)
EXECUTE PROCEDURE increment_koll_vak();


CREATE TRIGGER trg_increment_koll_vak_after_Update
AFTER Update ON trud_kniga
FOR EACH ROW WHEN (NEW.flag_yvl = 1)
EXECUTE PROCEDURE increment_koll_vak();



CREATE OR REPLACE FUNCTION decrease_koll_vak() RETURNS TRIGGER AS $$
BEGIN
    IF NEW.id_otdel IS NOT NULL THEN
        UPDATE otdel SET koll_vak = koll_vak - 1 WHERE id_otdel = NEW.id_otdel;
    END IF;
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trg_decrease_koll_vak_after_insert_sotrudnik
AFTER INSERT ON sotrudnik
FOR EACH ROW EXECUTE PROCEDURE decrease_koll_vak();

CREATE TRIGGER trg_decrease_koll_vak_after_insert_rukovoditel
AFTER INSERT ON rukovoditel
FOR EACH ROW EXECUTE PROCEDURE decrease_koll_vak();


CREATE OR REPLACE FUNCTION priem_na_rab_vak() RETURNS TRIGGER AS $$
DECLARE
    v_id_otdel INT;
BEGIN
    IF NEW.flag_yvl = 0 THEN
        SELECT id_otdel INTO v_id_otdel FROM (
            SELECT id_otdel FROM sotrudnik WHERE id_sotr = NEW.id_sotr UNION ALL
            SELECT id_otdel FROM rukovoditel WHERE id_ruk = NEW.id_ruk
        ) subquery LIMIT 1;

        IF FOUND THEN
            UPDATE otdel SET koll_vak = koll_vak + 1 WHERE id_otdel = v_id_otdel;
        END IF;
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;


CREATE TRIGGER trg_priem_na_rab_after_Update
AFTER Update ON trud_kniga
FOR EACH ROW WHEN (NEW.flag_yvl = 0)
EXECUTE PROCEDURE priem_na_rab_vak();


create or replace view ruk_and_status
as 
SELECT r.id_ruk as НомерРуководителя, r.familia || ' ' || r.imia || ' '|| r.otchectvo  as ФИО,
       CASE WHEN tt.flag_yvl = 1 THEN 'уволен'
            ELSE 'на работе'
       END AS Статус
FROM rukovoditel r
JOIN trud_kniga tt ON r.id_ruk = tt.id_ruk;



create or replace view sotr_and_status
as 
SELECT s.id_sotr  as  НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО,
       CASE WHEN tt.flag_yvl = 1 THEN 'уволен' 
            ELSE 'на работе'
       END AS Статус
FROM sotrudnik s
JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr;


create or replace view sotr_and_dolj
as 
SELECT s.id_sotr  as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО,
       CASE WHEN tt.flag_yvl = 1 THEN 'уволен' 
            ELSE 'на работе'
       END AS Статус, d.nazvanie_doljnosti as НазваниеДолжности
FROM sotrudnik s
JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr
JOIN doljnost d ON d.id_dolj = s.id_dolj;


create or replace view sotr_and_dolj_and_vremia
as 
SELECT s.id_sotr  as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО,
       CASE WHEN tt.flag_yvl = 1 THEN 'уволен' 
            ELSE 'на работе'
       END AS Статус, d.nazvanie_doljnosti as НазваниеДолжности, tt.date_priem_yvl as Дата
FROM sotrudnik s
JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr
JOIN doljnost d ON d.id_dolj = s.id_dolj;


create or replace view sotr_and_dolj_and_zp
as 
SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО,
       CASE WHEN tt.flag_yvl = 1 THEN 'уволен' 
            ELSE 'на работе'
       END AS Статус, d.nazvanie_doljnosti as НавзниеДолжности, d.zp as ЗП
FROM sotrudnik s
JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr
JOIN doljnost d ON d.id_dolj = s.id_dolj;

create or replace view sotr_and_dolj_and_pol
as 
SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО,
       CASE WHEN tt.flag_yvl = 1 THEN 'уволен' 
            ELSE 'на работе'
       END AS Статус, d.nazvanie_doljnosti as НазваниеДолжности, s.pol  as Пол
FROM sotrudnik s
JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr
JOIN doljnost d ON d.id_dolj = s.id_dolj;


create or replace view sotr_and_dolj_and_otdel
as 
SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО,
       CASE WHEN tt.flag_yvl = 1 THEN 'уволен' 
            ELSE 'на работе'
       END AS Статус, d.nazvanie_doljnosti as НазваниеДолжности, oo.nazvanie_otdela as НазваниеОтдела
FROM sotrudnik s
JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr
JOIN doljnost d ON d.id_dolj = s.id_dolj
join otdel oo on oo.id_otdel=s.id_otdel
join organizatsia org on org.id_organizatsia=oo.id_organizatsia;



