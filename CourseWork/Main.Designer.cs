﻿namespace CourseWork
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.datagridViewClients = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CurrentDate = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewDirections = new System.Windows.Forms.Button();
            this.ViewServices = new System.Windows.Forms.Button();
            this.AddClientFromFile = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Настройки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datagridViewClients
            // 
            this.datagridViewClients.AllowUserToAddRows = false;
            this.datagridViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column15,
            this.Column14,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.datagridViewClients.Location = new System.Drawing.Point(12, 59);
            this.datagridViewClients.Name = "datagridViewClients";
            this.datagridViewClients.ReadOnly = true;
            this.datagridViewClients.RowHeadersVisible = false;
            this.datagridViewClients.Size = new System.Drawing.Size(1375, 179);
            this.datagridViewClients.TabIndex = 2;
            this.datagridViewClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.datagridViewClients_MouseDoubleClick);
            // 
            // Column13
            // 
            this.Column13.HeaderText = "ID заказа";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Возрастная категория";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Способ оплаты";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Оформление заказа";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Посещение";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Название направления";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Название услуги";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Продолжительность";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Цена";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Код скидки";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Размер скидки";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 120;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавление клиента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(365, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CurrentDate
            // 
            this.CurrentDate.Location = new System.Drawing.Point(480, 28);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(100, 20);
            this.CurrentDate.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(613, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(171, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 36);
            this.button5.TabIndex = 9;
            this.button5.Text = "Вывести по дате";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(93, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 36);
            this.button6.TabIndex = 10;
            this.button6.Text = "Обновить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 35);
            this.button7.TabIndex = 11;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(378, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 36);
            this.button8.TabIndex = 12;
            this.button8.Text = "Поиск";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources._73e1bc97_2118_4e96_9366_a609b5c6f271;
            this.pictureBox1.Location = new System.Drawing.Point(586, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewDirections
            // 
            this.ViewDirections.Location = new System.Drawing.Point(446, 239);
            this.ViewDirections.Name = "ViewDirections";
            this.ViewDirections.Size = new System.Drawing.Size(134, 38);
            this.ViewDirections.TabIndex = 14;
            this.ViewDirections.Text = "Просмотр направлений";
            this.ViewDirections.UseVisualStyleBackColor = true;
            this.ViewDirections.Click += new System.EventHandler(this.ViewDirections_Click);
            // 
            // ViewServices
            // 
            this.ViewServices.Location = new System.Drawing.Point(116, 240);
            this.ViewServices.Name = "ViewServices";
            this.ViewServices.Size = new System.Drawing.Size(102, 37);
            this.ViewServices.TabIndex = 15;
            this.ViewServices.Text = "Просмотр услуг";
            this.ViewServices.UseVisualStyleBackColor = true;
            this.ViewServices.Click += new System.EventHandler(this.ViewServices_Click);
            // 
            // AddClientFromFile
            // 
            this.AddClientFromFile.Location = new System.Drawing.Point(586, 239);
            this.AddClientFromFile.Name = "AddClientFromFile";
            this.AddClientFromFile.Size = new System.Drawing.Size(166, 38);
            this.AddClientFromFile.TabIndex = 16;
            this.AddClientFromFile.Text = "Добавить клиентов из файла";
            this.AddClientFromFile.UseVisualStyleBackColor = true;
            this.AddClientFromFile.Click += new System.EventHandler(this.AddClientFromFile_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 38);
            this.button4.TabIndex = 17;
            this.button4.Text = "Просмотр скидок";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(284, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 35);
            this.button9.TabIndex = 18;
            this.button9.Text = "Вывести всех";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 290);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.AddClientFromFile);
            this.Controls.Add(this.ViewServices);
            this.Controls.Add(this.ViewDirections);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.datagridViewClients);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Список клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datagridViewClients;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CurrentDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ViewDirections;
        private System.Windows.Forms.Button ViewServices;
        private System.Windows.Forms.Button AddClientFromFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
    }
}