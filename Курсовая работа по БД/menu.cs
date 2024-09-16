using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Курсовая_работа_по_БД
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            if(static_class.koll_vxod==1)
            {
                button1.Visible=true;
                button2.Visible=true;
                button3.Visible=true;
                button4.Visible=true;
                button5.Visible=true;
                button6.Visible=true;
                button7.Visible=true;

            }
            else 
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = true;
                button5.Visible = false;
                button6.Visible = true;
                button7.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            doljnost doljnost = new doljnost();
            doljnost.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            organizasia organizasia = new organizasia();
            organizasia.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            otdel otdel = new otdel();
            otdel.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rukovoditel rukovoditel = new rukovoditel();
            rukovoditel.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sotrudnik sotrudnik = new sotrudnik();
            sotrudnik.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Yval yval = new Yval();
            yval.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inftablo inftablo = new inftablo();
            inftablo.ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
