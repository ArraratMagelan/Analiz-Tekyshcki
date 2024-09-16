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
    public partial class doljnost : Form
    {
        public doljnost()
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
                comboBox2.BackColor = Color.White;
                comboBox1.BackColor = Color.White;

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedItem.ToString() == "" || comboBox2.SelectedItem.ToString() == "")
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
                    if (comboBox2.Text == "")
                    {
                        comboBox2.BackColor = Color.Red;
                    }
                    if (comboBox1.Text == "")
                    {
                        comboBox1.BackColor = Color.Red;
                    }
                    throw new Exception("Одно из полей не введено");
                }
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("insert into doljnost values (default, '{0}', {1}, '{2}', '{3}', '{4}');", textBox1.Text, textBox2.Text, comboBox1.SelectedItem.ToString(), textBox3.Text, comboBox2.SelectedItem.ToString());
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Должность добавлена");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                comboBox1.SelectedItem = "";
                comboBox2.SelectedItem = "";
            }
            catch (Exception ex) { MessageBox.Show("Значения введены не корректно"); }
        }

    }
}
