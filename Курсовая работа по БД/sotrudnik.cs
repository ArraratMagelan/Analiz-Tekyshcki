using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа_по_БД
{
    public partial class sotrudnik : Form
    {
        public sotrudnik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White; 
                comboBox1.BackColor = Color.White;
                comboBox2.BackColor = Color.White;
                comboBox3.BackColor = Color.White;
                comboBox4.BackColor = Color.White;
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "")
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.BackColor = Color.Red;
                    }
                    if (textBox2.Text == "")
                    {
                        textBox2.BackColor = Color.Red;
                    }
                    if (textBox3.Text == "")
                    {
                        textBox3.BackColor = Color.Red;
                    } 
                    if (comboBox1.Text == "")
                    {
                        comboBox1.BackColor = Color.Red;
                    }
                    if (comboBox2.Text == "")
                    {
                        comboBox2.BackColor = Color.Red;
                    }
                    if (comboBox3.Text == "")
                    {
                        comboBox3.BackColor = Color.Red;
                    }
                    if (comboBox4.Text == "")
                    {
                        comboBox4.BackColor = Color.Red;
                    }

                    throw new Exception("Одно из полей не введено");
                }
                string dateString1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string dateString2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");




              


                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;


                string ID_ = "";
                string id_ot = comboBox3.SelectedItem.ToString();
                command.CommandText = String.Format("select id_otdel from otdel where nazvanie_otdela='{0}'", id_ot);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    ID_ = data.Rows[0][0].ToString();
                }
                reader.Close();


                string ID_1 = "";
                string id_ot1 = comboBox4.SelectedItem.ToString();
                command.CommandText = String.Format("select id_dolj from doljnost where nazvanie_doljnosti='{0}'", id_ot1);
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    ID_1 = data.Rows[0][0].ToString();
                }
                reader.Close();

                command.CommandText = String.Format("insert into sotrudnik values (default, '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, {7});", textBox1.Text, textBox2.Text, textBox3.Text, dateString1, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), ID_, ID_1);
                command.ExecuteNonQuery();
                command.CommandText = String.Format("select id_sotr from sotrudnik order by id_sotr desc limit 1;");
                reader = command.ExecuteReader();
                string ID = "";
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    ID = data.Rows[0][0].ToString();
                }
                reader.Close();
                command.CommandText = String.Format("insert into trud_kniga values (default, '{0}', {1}, '{2}', ' ', null, {3} );", dateString2, 0, textBox4.Text, ID);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Сотрудник добавлен");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
            catch (Exception ex) { MessageBox.Show("Значения введены не корректно"); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!static_class.kollotdelov())
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select   nazvanie_otdela from otdel");
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
            if (!static_class.kolldloj())
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select   nazvanie_doljnosti from doljnost");
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

        private void sotrudnik_Load(object sender, EventArgs e)
        {
            static_class.koll_otdelov = "0";
            static_class.koll_otdelov_new = "0";
            static_class.koll_org = "0";
            static_class.koll_org_new = "0";
            NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select   nazvanie_otdela from otdel");
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

            command.CommandText = String.Format("select   nazvanie_doljnosti from doljnost");
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
    }
}


