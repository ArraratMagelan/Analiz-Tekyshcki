using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая_работа_по_БД
{
    public partial class otdel : Form
    {
        public otdel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!static_class.kollorg())
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select name_org from organizatsia");
                comboBox2.Items.Clear();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        comboBox2.Items.Add(data.Rows[i][0].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                comboBox1.BackColor = Color.White;
                comboBox2.BackColor = Color.White;
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedItem.ToString() == "" || comboBox2.SelectedItem.ToString() == "")
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.BackColor = Color.Red;
                    }
                    if (textBox2.Text == "")
                    {
                        textBox2.BackColor = Color.Red;
                    }
                    if (comboBox1.Text == "")
                    {
                        comboBox1.BackColor = Color.Red;
                    }
                    if (comboBox2.Text == "")
                    {
                        comboBox2.BackColor = Color.Red;
                    }
                        throw new Exception("Одно из полей не введено");
                }
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                string ID_org = "";
                string id_org = comboBox2.SelectedItem.ToString();
                command.CommandText = String.Format("select id_organizatsia from organizatsia where name_org='{0}'", id_org);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    ID_org = data.Rows[0][0].ToString();
                }
                reader.Close();

                command.CommandText = String.Format("insert into otdel values (default, '{0}', {1}, {1}, '{2}', {3});", textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), ID_org);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Отдел добавлен");
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedItem = "";
                comboBox2.SelectedItem = "";
            }
            catch (Exception ex) { MessageBox.Show("Значения введены не корректно"); }
        }

        private void otdel_Load(object sender, EventArgs e)
        {
            static_class.koll_org = "0";
            static_class.koll_org_new = "0";
            NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;
            command.CommandText = String.Format("select  name_org from organizatsia");
            comboBox2.Items.Clear();
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable data = new DataTable();
                data.Load(reader);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    comboBox2.Items.Add(data.Rows[i][0].ToString());
                }
            }
            reader.Close();
            command.Dispose();
            sqlConnection.Close();
        }
    }
}
