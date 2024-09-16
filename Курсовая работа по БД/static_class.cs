using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Npgsql; 

namespace Курсовая_работа_по_БД
{
    static internal class static_class
    {
        public static string sqlcon = "";

        public static int koll_vxod = 0;

        public static void izmncon(int a)
        {
            if(a==1)
            {
                sqlcon= "Server=localhost;Port=5432;Database=tekyuchka;User Id=menedjer; Password=menedjer123QWE;";
                koll_vxod = 1;
            }
            else
            {
                sqlcon = "Server=localhost;Port=5432;Database=tekyuchka;User Id=kadri; Password=kadri123QWE;";
                koll_vxod = 2;
            }
        }

        public static string koll_org = "0";

        public static string koll_org_new = "0";
        public static bool kollorg()
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(sqlcon);
            sqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;

            if(koll_org=="0")
            {

                command.CommandText = String.Format("select count(*) from organizatsia;");
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    koll_org = data.Rows[0][0].ToString();
                    koll_org_new = data.Rows[0][0].ToString();
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
                return false;
            }
            else
            {

                command.CommandText = String.Format("select count(*) from organizatsia;");
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    koll_org_new = data.Rows[0][0].ToString();
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();

                if (koll_org== koll_org_new)
                {
                    return true;
                }
                else
                {
                    koll_org = koll_org_new;
                    return false;
                }
            }
        }




        public static string koll_otdelov = "0";

        public static string koll_otdelov_new = "0";
        public static bool kollotdelov()
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(sqlcon);
            sqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;

            if (koll_otdelov == "0")
            {

                command.CommandText = String.Format("select count(*) from otdel;");
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    koll_otdelov = data.Rows[0][0].ToString();
                    koll_otdelov_new = data.Rows[0][0].ToString();
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
                return false;
            }
            else
            {

                command.CommandText = String.Format("select count(*) from otdel;");
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    koll_otdelov_new = data.Rows[0][0].ToString();
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();

                if (koll_otdelov == koll_otdelov_new)
                {
                    return true;
                }
                else
                {
                    koll_otdelov = koll_otdelov_new;
                    return false;
                }
            }
        }



        public static string koll_dloj = "0";

        public static string koll_dloj_new = "0";
        public static bool kolldloj()
        {
            NpgsqlConnection sqlConnection = new NpgsqlConnection(sqlcon);
            sqlConnection.Open();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;

            if (koll_dloj == "0")
            {

                command.CommandText = String.Format("select count(*) from doljnost;");
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    koll_dloj = data.Rows[0][0].ToString();
                    koll_dloj_new = data.Rows[0][0].ToString();
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();
                return false;
            }
            else
            {

                command.CommandText = String.Format("select count(*) from doljnost;");
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    koll_dloj_new = data.Rows[0][0].ToString();
                }
                reader.Close();
                command.Dispose();
                sqlConnection.Close();

                if (koll_dloj == koll_dloj_new)
                {
                    return true;
                }
                else
                {
                    koll_dloj = koll_dloj_new;
                    return false;
                }
            }
        }
    }
}
