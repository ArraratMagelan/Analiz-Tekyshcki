using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Курсовая_работа_по_БД
{
    public partial class Yval : Form
    {
        public Yval()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedItem == null)
                {
                    
                    throw new Exception("Поле ID пустое");
                }
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;


                string ID = "";
                string[] fio = comboBox3.SelectedItem.ToString().Split(' '); 
                command.CommandText = String.Format("select id_ruk from rukovoditel where familia='{0}' and imia='{1}' and otchectvo='{2}'", fio[0], fio[1], fio[2]);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    ID = data.Rows[0][0].ToString();
                }
                reader.Close();
              
                string yvl = "";
                if (comboBox2.SelectedItem.ToString() == "Уволить")
                {
                    yvl = "1";
                }
                else
                {
                    yvl = "0";
                }
                command.CommandText = String.Format("update trud_kniga set flag_yvl={0}, novoe_mesto_rab='{1}', date_priem_yvl=CURRENT_DATE where id_ruk={2}", yvl, textBox3.Text, ID);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Статус турдоустройства изменён");
                comboBox2.SelectedItem = "";
                comboBox3.SelectedItem = "";
                textBox3.Clear();
            }
            catch (Exception ex) { MessageBox.Show("Значения введены не корректно"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select * from ruk_and_status");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();

                comboBox3.Items.Clear();
                command.CommandText = String.Format("select familia || ' ' ||  imia ||' '||otchectvo  from rukovoditel");
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


                command.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex) { MessageBox.Show("Значения введены не корректно"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("select * from sotr_and_status");
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    dataGridView1.DataSource = data;
                }
                reader.Close();
                comboBox4.Items.Clear();
                command.CommandText = String.Format("select familia || ' ' ||  imia ||' '||otchectvo  from sotrudnik");
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
            catch (Exception ex) { MessageBox.Show("Значения введены не корректно"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox4.SelectedItem==null)
                {
                    throw new Exception("Поле ID пустое");
                }
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                string ID = "";
                string[] fio = comboBox4.SelectedItem.ToString().Split(' ');
                command.CommandText = String.Format("select id_ruk from rukovoditel where familia='{0}' and imia='{1}' and otchectvo='{2}'", fio[0], fio[1], fio[2]);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable data = new DataTable();
                    data.Load(reader);
                    ID = data.Rows[0][0].ToString();
                }
                reader.Close();
                string yvl = "";
                if (comboBox1.SelectedItem.ToString() == "Уволить")
                {
                    yvl = "1";
                }
                else
                {
                    yvl = "0";
                }
                command.CommandText = String.Format("update trud_kniga set flag_yvl={0}, novoe_mesto_rab='{1}', date_priem_yvl=CURRENT_DATE where id_sotr={2}", yvl, textBox4.Text, ID);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Статус турдоустройства изменён");
                textBox4.Clear();
                comboBox4.SelectedItem = "";
                comboBox1.SelectedItem = "";
            }
            catch(Exception ex) { MessageBox.Show("Значения введены не корректно"   );}
        }
    }
}
