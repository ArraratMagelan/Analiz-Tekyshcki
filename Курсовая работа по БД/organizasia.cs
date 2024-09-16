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
    public partial class organizasia : Form
    {
        public organizasia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            try
            {
                if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text =="" || textBox4.Text=="" || textBox5.Text =="")
                {
                    if(textBox1.Text=="")
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
                    if (textBox4.Text == "")
                    {
                        textBox4.BackColor = Color.Red;
                    }
                    if (textBox5.Text == "")
                    {
                        textBox5.BackColor = Color.Red;
                    }
                    throw new Exception("Одно из полей не введено");
                }
                NpgsqlConnection sqlConnection = new NpgsqlConnection(static_class.sqlcon);
                sqlConnection.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = sqlConnection;
                command.CommandType = CommandType.Text;
                command.CommandText = String.Format("insert into organizatsia values (default, '{0}', {1}, '{2}', {3}, '{4}');", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                command.ExecuteNonQuery();
                command.Dispose();
                sqlConnection.Close();
                MessageBox.Show("Организация добавлена");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            catch(Exception ex) { MessageBox.Show("Значения введены не корректно"); }
        }
    }
}
