using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Курсовая_работа_по_БД
{
    public partial class inftablo : Form
    {
        public inftablo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select * from organizatsia;");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select * from otdel;");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select * from sotr_and_status;");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void inftablo_Load(object sender, EventArgs e)
        {
            static_class.koll_otdelov = "0";
            static_class.koll_otdelov_new = "0";
            static_class.koll_org = "0";
            static_class.koll_org_new = "0";
            static_class.koll_org = "0";
            static_class.koll_org_new = "0";
            NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select   nazvanie_doljnosti from doljnost");
            comboBox1.Items.Clear();
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    comboBox1.Items.Add(data.Rows[i][0].ToString());
                }
            }
            reader.Close();
            command.CommandText = String.Format("select   name_org from organizatsia");
            comboBox3.Items.Clear();
                reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    comboBox3.Items.Add(data.Rows[i][0].ToString());
                }
            }
            reader.Close();

            command.CommandText = String.Format("select   nazvanie_otdela from otdel");
            comboBox4.Items.Clear();
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    comboBox4.Items.Add(data.Rows[i][0].ToString());
                }
            }
            reader.Close();
            command.Dispose();
            sqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select * from ruk_and_status;");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select * from doljnost;");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                string ID = "";
                string nz_dlj = comboBox1.SelectedItem.ToString();
                NpgsqlDataReader reader;
                if (checkBox1.Checked)
                {
                    string ID_org="";
                    string id_org = comboBox3.SelectedItem.ToString();
                    command.CommandText = String.Format("select id_organizatsia from organizatsia where name_org='{0}'", id_org);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        ID_org = data.Rows[0][0].ToString();
                    }
                    reader.Close();
                    command.CommandText = String.Format("SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО, CASE WHEN tt.flag_yvl = 1 THEN 'уволен' ELSE 'на работе' END AS Стаутс, d.nazvanie_doljnosti  as НазваниеДолжности FROM sotrudnik s JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr JOIN doljnost d ON d.id_dolj = s.id_dolj join otdel ot on ot.id_otdel=s.id_otdel join organizatsia og on og.id_organizatsia=ot.id_organizatsia where  og.id_organizatsia={0} and  nazvanie_doljnosti='{1}';", ID_org, nz_dlj);
                }
                else
                {
                    command.CommandText = String.Format("select * from sotr_and_dolj where nazvanie_doljnosti='{0}';", nz_dlj);
                }

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!static_class.kolldloj())
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select  nazvanie_doljnosti from doljnost");
                comboBox1.Items.Clear();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        comboBox1.Items.Add(data.Rows[i][0].ToString());
                    }
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();

            }
            else
            {

            }
            if (!static_class.kollorg())
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select   name_org from organizatsia");
                comboBox3.Items.Clear();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        comboBox3.Items.Add(data.Rows[i][0].ToString());
                    }
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();

            }
            else
            {

            }
            if (!static_class.kollotdelov())
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select   nazvanie_otdela from otdel");
                comboBox4.Items.Clear();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        comboBox4.Items.Add(data.Rows[i][0].ToString());
                    }
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();

            }
            else
            {

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;

                NpgsqlDataReader reader;
                if (checkBox1.Checked)
                {
                    string ID_org = "";
                    string id_org = comboBox3.SelectedItem.ToString();
                    command.CommandText = String.Format("select id_organizatsia from organizatsia where name_org='{0}'", id_org);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        ID_org = data.Rows[0][0].ToString();
                    }
                    reader.Close();
                    command.CommandText = String.Format("SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО, CASE WHEN tt.flag_yvl = 1 THEN 'уволен' ELSE 'на работе' END AS Стаутс, d.nazvanie_doljnosti as НазваниеДолжности,tt.date_priem_yvl as Дата FROM sotrudnik s JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr JOIN doljnost d ON d.id_dolj = s.id_dolj join otdel ot on ot.id_otdel=s.id_otdel join organizatsia og on og.id_organizatsia=ot.id_organizatsia where  og.id_organizatsia={0} and (tt.date_priem_yvl>='{1}' and tt.date_priem_yvl<='{2}');", ID_org, textBox1.Text,textBox2.Text);
                }
                else
                {
                    command.CommandText = String.Format("select * from sotr_and_dolj_and_vremia where date_priem_yvl>='{0}' and date_priem_yvl<='{1}';", textBox1.Text, textBox2.Text);
                }
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;

                NpgsqlDataReader reader;
                if (radioButton1.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        string id_org = comboBox3.SelectedItem.ToString();
                        command.CommandText = String.Format("select id_organizatsia from organizatsia where name_org='{0}'", id_org);
                        reader = command.ExecuteReader();
                        string ID_org = "";
                        if (reader.HasRows)
                        {
                            DataTable data = new DataTable();
                            data.Load(reader);
                            ID_org = data.Rows[0][0].ToString();
                        }
                        reader.Close();
                        command.CommandText = String.Format("SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО, CASE WHEN tt.flag_yvl = 1 THEN 'уволен' ELSE 'на работе' END AS Стаутс, d.nazvanie_doljnosti as НазваниеДолжности, d.zp as ЗП FROM sotrudnik s JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr jOIN doljnost d ON d.id_dolj = s.id_dolj join otdel ot on ot.id_otdel=s.id_otdel join organizatsia og on og.id_organizatsia=ot.id_organizatsia where  og.id_organizatsia={0} and d.zp >= {1};", ID_org, textBox3.Text);
                    }
                    else
                    {
                        command.CommandText = String.Format("select * from sotr_and_dolj_and_zp where zp>={0};", textBox3.Text);
                    }
                }
                if (radioButton2.Checked)
                {
                    if (checkBox1.Checked)
                    {
                        string id_org = comboBox3.SelectedItem.ToString();
                        command.CommandText = String.Format("select id_organizatsia from organizatsia where name_org='{0}'", id_org);
                        reader = command.ExecuteReader();
                        string ID_org = "";
                        if (reader.HasRows)
                        {
                            DataTable data = new DataTable();
                            data.Load(reader);
                            ID_org = data.Rows[0][0].ToString();
                        }
                        reader.Close();
                        command.CommandText = String.Format("SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО, CASE WHEN tt.flag_yvl = 1 THEN 'уволен' ELSE 'на работе' END AS Стаутс, d.nazvanie_doljnosti as НазваниеДолжности, d.zp as ЗП FROM sotrudnik s JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr jOIN doljnost d ON d.id_dolj = s.id_dolj join otdel ot on ot.id_otdel=s.id_otdel join organizatsia og on og.id_organizatsia=ot.id_organizatsia where  og.id_organizatsia={0} and d.zp <= {1};", ID_org, textBox3.Text);
                    }
                    else
                    {
                        command.CommandText = String.Format("select * from sotr_and_dolj_and_zp where zp<={0};", textBox3.Text);
                    }
                }

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;

                NpgsqlDataReader reader;
                if (checkBox1.Checked)
                {
                    string ID_org = "";
                    string id_org = comboBox3.SelectedItem.ToString();
                    command.CommandText = String.Format("select id_organizatsia from organizatsia where name_org='{0}'", id_org);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        ID_org = data.Rows[0][0].ToString();
                    }
                    reader.Close();
                    command.CommandText = String.Format("SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО, CASE WHEN tt.flag_yvl = 1 THEN 'уволен' ELSE 'на работе' END AS Стаутс, d.nazvanie_doljnosti as НазваниеДолжности,s.pol as Пол FROM sotrudnik s JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr JOIN doljnost d ON d.id_dolj = s.id_dolj join otdel ot on ot.id_otdel=s.id_otdel join organizatsia og on og.id_organizatsia=ot.id_organizatsia where  og.id_organizatsia={0} and s.pol='{1}';", ID_org, comboBox2.SelectedItem.ToString());
                }
                else
                {
                    command.CommandText = String.Format("select * from sotr_and_dolj_and_pol where pol='{0}';", comboBox2.SelectedItem.ToString());
                }

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = null; 
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;

                string[] name_otdel = comboBox4.SelectedItem.ToString().Split(' ');
                string n = "";
                for (int i = 0; i < name_otdel.Length; i++)
                {
                    n += name_otdel[i];
                    if (i != name_otdel.Length - 1)
                    {
                        n += " ";
                    }
                }
                NpgsqlDataReader reader;
                if (checkBox1.Checked)
                {
                    string ID_org = "";
                    string id_org = comboBox3.SelectedItem.ToString();
                    command.CommandText = String.Format("select id_organizatsia from organizatsia where name_org='{0}'", id_org);
                    reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);
                        ID_org = data.Rows[0][0].ToString();
                    }
                    reader.Close();
                    command.CommandText = String.Format("SELECT s.id_sotr as НомерСотрудника,s.familia || ' ' || s.imia || ' '|| s.otchectvo as ФИО, CASE WHEN tt.flag_yvl = 1 THEN 'уволен' ELSE 'на работе' END AS Стаутс, d.nazvanie_doljnosti as НазваниеДолжности,ot.nazvanie_otdela  as НазваниеОтдела FROM sotrudnik s JOIN trud_kniga tt ON s.id_sotr = tt.id_sotr JOIN doljnost d ON d.id_dolj = s.id_dolj join otdel ot on ot.id_otdel=s.id_otdel join organizatsia og on og.id_organizatsia=ot.id_organizatsia where  og.id_organizatsia={0} and ot.nazvanie_otdela='{1}';", ID_org, n);
                }
                else
                {
                    command.CommandText = String.Format("select * from sotr_and_dolj_and_otdel where nazvanie_otdela>='{0}';", n);
                }

                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    
    }
}
