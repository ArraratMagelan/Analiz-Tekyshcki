namespace Курсовая_работа_по_БД
{
    partial class sotrudnik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox4 = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            label8 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            comboBox3 = new System.Windows.Forms.ComboBox();
            label7 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            comboBox4 = new System.Windows.Forms.ComboBox();
            label10 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(421, 304);
            textBox4.Margin = new System.Windows.Forms.Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(343, 27);
            textBox4.TabIndex = 37;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(421, 281);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(195, 19);
            label9.TabIndex = 36;
            label9.Text = "Прежнее место работы";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(421, 238);
            dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(343, 27);
            dateTimePicker2.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(421, 215);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(192, 19);
            label8.TabIndex = 34;
            label8.Text = "Дата приема на работу";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(17, 357);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(749, 29);
            button1.TabIndex = 33;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(421, 111);
            comboBox3.Margin = new System.Windows.Forms.Padding(4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(343, 27);
            comboBox3.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(421, 89);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(57, 19);
            label7.TabIndex = 31;
            label7.Text = "Отдел";
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Мужчина", "Женщина" });
            comboBox2.Location = new System.Drawing.Point(421, 42);
            comboBox2.Margin = new System.Windows.Forms.Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(343, 27);
            comboBox2.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(421, 19);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(41, 19);
            label6.TabIndex = 29;
            label6.Text = "Пол";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Нет", "Среднее", "Среднее проф", "Высшее" });
            comboBox1.Location = new System.Drawing.Point(17, 304);
            comboBox1.Margin = new System.Windows.Forms.Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(343, 27);
            comboBox1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(17, 281);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(115, 19);
            label5.TabIndex = 27;
            label5.Text = "Образование";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(17, 215);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 19);
            label4.TabIndex = 26;
            label4.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(17, 238);
            dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(343, 27);
            dateTimePicker1.TabIndex = 25;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(17, 170);
            textBox3.Margin = new System.Windows.Forms.Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(343, 27);
            textBox3.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(17, 147);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 19);
            label3.TabIndex = 23;
            label3.Text = "Отчество";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(17, 100);
            textBox2.Margin = new System.Windows.Forms.Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(343, 27);
            textBox2.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 77);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 19);
            label2.TabIndex = 21;
            label2.Text = "Имя";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(17, 42);
            textBox1.Margin = new System.Windows.Forms.Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(343, 27);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 19);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 19);
            label1.TabIndex = 19;
            label1.Text = "Фамилия";
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(421, 170);
            comboBox4.Margin = new System.Windows.Forms.Padding(4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(343, 27);
            comboBox4.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(421, 147);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(99, 19);
            label10.TabIndex = 38;
            label10.Text = "Должность";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // sotrudnik
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(793, 414);
            Controls.Add(comboBox4);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label9);
            Controls.Add(dateTimePicker2);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(label7);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "sotrudnik";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Сотрудник";
            Load += sotrudnik_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
    }
}