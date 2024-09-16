using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа_по_БД
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text== "menedjer" && textBox2.Text== "menedjer123QWE")
                {
                    MessageBox.Show("Добро пожаловать менеджер");
                    static_class.izmncon(1);
                    menu menu1 = new menu();
                    menu1.ShowDialog();
                }
                else 
                {
                    if(textBox1.Text== "kadri" && textBox2.Text== "kadri123QWE")
                    {
                        MessageBox.Show("Добро пожаловать работник кадров");
                        static_class.izmncon(2);
                        menu menu1 = new menu();
                        menu1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели неверные данные");
                        static_class.koll_vxod++;
                    }
                }
                if(static_class.koll_vxod==5)
                {
                    static_class.koll_vxod = 0;
                    MessageBox.Show("Вы ввели пароль слишком много раз ва заблокированы на 20 секунд");
                    Thread.Sleep(20000);
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
