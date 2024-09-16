namespace Курсовая_работа_по_БД
{
    partial class Yval
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            textBox3 = new System.Windows.Forms.TextBox();
            textBox4 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            comboBox3 = new System.Windows.Forms.ComboBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(17, 15);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1361, 429);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(17, 466);
            button1.Margin = new System.Windows.Forms.Padding(4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(688, 29);
            button1.TabIndex = 1;
            button1.Text = "Получить руководителей и их статус трудоустройства";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(713, 466);
            button2.Margin = new System.Windows.Forms.Padding(4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(665, 29);
            button2.TabIndex = 2;
            button2.Text = "Получить сотрудников и их статус трудоустройства";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(713, 507);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(400, 19);
            label1.TabIndex = 3;
            label1.Text = "Выберите ФИО сотрудника и измените его статус";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Уволить", "Принять на работу" });
            comboBox1.Location = new System.Drawing.Point(713, 537);
            comboBox1.Margin = new System.Windows.Forms.Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(666, 27);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Уволить", "Принять на работу" });
            comboBox2.Location = new System.Drawing.Point(22, 537);
            comboBox2.Margin = new System.Windows.Forms.Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(683, 27);
            comboBox2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(20, 507);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(420, 19);
            label2.TabIndex = 6;
            label2.Text = "Выберите ФИО руководителя и измените его статус";
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(20, 630);
            button3.Margin = new System.Windows.Forms.Padding(4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(685, 29);
            button3.TabIndex = 9;
            button3.Text = "Выполнить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(716, 630);
            button4.Margin = new System.Windows.Forms.Padding(4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(662, 29);
            button4.TabIndex = 10;
            button4.Text = "Выполнить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(20, 593);
            textBox3.Margin = new System.Windows.Forms.Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(685, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(716, 593);
            textBox4.Margin = new System.Windows.Forms.Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(662, 27);
            textBox4.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 570);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(172, 19);
            label3.TabIndex = 13;
            label3.Text = "Новое место работы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(716, 570);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(172, 19);
            label4.TabIndex = 14;
            label4.Text = "Новое место работы";
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(448, 502);
            comboBox3.Margin = new System.Windows.Forms.Padding(4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(257, 27);
            comboBox3.TabIndex = 15;
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new System.Drawing.Point(1121, 503);
            comboBox4.Margin = new System.Windows.Forms.Padding(4);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(257, 27);
            comboBox4.TabIndex = 16;
            // 
            // Yval
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1392, 670);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Yval";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Увольнение";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}