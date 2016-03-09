namespace CourseWork.Client
{
    partial class AddClient
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
            this.Add = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Direction = new System.Windows.Forms.GroupBox();
            this.DirectionName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Service = new System.Windows.Forms.ComboBox();
            this.Услуга = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeCategory = new System.Windows.Forms.ComboBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Client = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameOfClient = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Decor = new System.Windows.Forms.ComboBox();
            this.Payment = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Direction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Client.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(228, 402);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 34);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(337, 402);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 34);
            this.Close.TabIndex = 11;
            this.Close.Text = "Выйти";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 155);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Direction
            // 
            this.Direction.Controls.Add(this.DirectionName);
            this.Direction.Controls.Add(this.label10);
            this.Direction.Controls.Add(this.Service);
            this.Direction.Controls.Add(this.Услуга);
            this.Direction.Controls.Add(this.comboBox1);
            this.Direction.Controls.Add(this.label8);
            this.Direction.Location = new System.Drawing.Point(351, 12);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(333, 152);
            this.Direction.TabIndex = 14;
            this.Direction.TabStop = false;
            this.Direction.Text = "Информация о направлении";
            // 
            // DirectionName
            // 
            this.DirectionName.FormattingEnabled = true;
            this.DirectionName.Items.AddRange(new object[] {
            "Несовершеннолетний",
            "Взрослый",
            "Пожилой(от 65)"});
            this.DirectionName.Location = new System.Drawing.Point(28, 32);
            this.DirectionName.Name = "DirectionName";
            this.DirectionName.Size = new System.Drawing.Size(280, 21);
            this.DirectionName.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Направление";
            // 
            // Service
            // 
            this.Service.FormattingEnabled = true;
            this.Service.Items.AddRange(new object[] {
            "Несовершеннолетний",
            "Взрослый",
            "Пожилой(от 65)"});
            this.Service.Location = new System.Drawing.Point(28, 75);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(280, 21);
            this.Service.TabIndex = 18;
            // 
            // Услуга
            // 
            this.Услуга.AutoSize = true;
            this.Услуга.Location = new System.Drawing.Point(25, 59);
            this.Услуга.Name = "Услуга";
            this.Услуга.Size = new System.Drawing.Size(122, 13);
            this.Услуга.TabIndex = 17;
            this.Услуга.Text = "Возрастная категория";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Несовершеннолетний",
            "Взрослый",
            "Пожилой(от 65)"});
            this.comboBox1.Location = new System.Drawing.Point(28, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Возрастная категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // Date
            // 
            this.Date.Enabled = false;
            this.Date.Location = new System.Drawing.Point(11, 155);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(280, 20);
            this.Date.TabIndex = 7;
            this.Date.TextChanged += new System.EventHandler(this.Date_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата";
            // 
            // Middlename
            // 
            this.Middlename.Location = new System.Drawing.Point(11, 116);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(280, 20);
            this.Middlename.TabIndex = 5;
            this.Middlename.TextChanged += new System.EventHandler(this.Middlename_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Возрастная категория";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // AgeCategory
            // 
            this.AgeCategory.FormattingEnabled = true;
            this.AgeCategory.Items.AddRange(new object[] {
            "Несовершеннолетний",
            "Взрослый",
            "Пожилой(от 65)"});
            this.AgeCategory.Location = new System.Drawing.Point(11, 199);
            this.AgeCategory.Name = "AgeCategory";
            this.AgeCategory.Size = new System.Drawing.Size(280, 21);
            this.AgeCategory.TabIndex = 12;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(11, 32);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(280, 20);
            this.Lastname.TabIndex = 1;
            this.Lastname.TextChanged += new System.EventHandler(this.Lastname_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources._73e1bc97_2118_4e96_9366_a609b5c6f271;
            this.pictureBox1.Location = new System.Drawing.Point(297, 155);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Client
            // 
            this.Client.Controls.Add(this.monthCalendar1);
            this.Client.Controls.Add(this.Payment);
            this.Client.Controls.Add(this.Decor);
            this.Client.Controls.Add(this.NameOfClient);
            this.Client.Controls.Add(this.label2);
            this.Client.Controls.Add(this.pictureBox1);
            this.Client.Controls.Add(this.label7);
            this.Client.Controls.Add(this.label6);
            this.Client.Controls.Add(this.Lastname);
            this.Client.Controls.Add(this.AgeCategory);
            this.Client.Controls.Add(this.label1);
            this.Client.Controls.Add(this.label5);
            this.Client.Controls.Add(this.Middlename);
            this.Client.Controls.Add(this.label4);
            this.Client.Controls.Add(this.Date);
            this.Client.Controls.Add(this.label3);
            this.Client.Location = new System.Drawing.Point(12, 12);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(322, 335);
            this.Client.TabIndex = 13;
            this.Client.TabStop = false;
            this.Client.Text = "Информация о клиенте";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Имя";
            // 
            // NameOfClient
            // 
            this.NameOfClient.Location = new System.Drawing.Point(9, 75);
            this.NameOfClient.Name = "NameOfClient";
            this.NameOfClient.Size = new System.Drawing.Size(280, 20);
            this.NameOfClient.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Оформление заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Способ оплаты";
            // 
            // Decor
            // 
            this.Decor.FormattingEnabled = true;
            this.Decor.Items.AddRange(new object[] {
            "По телефону",
            "По прибытию"});
            this.Decor.Location = new System.Drawing.Point(11, 292);
            this.Decor.Name = "Decor";
            this.Decor.Size = new System.Drawing.Size(280, 21);
            this.Decor.TabIndex = 20;
            // 
            // Payment
            // 
            this.Payment.FormattingEnabled = true;
            this.Payment.Items.AddRange(new object[] {
            "Наличный",
            "Безналичный"});
            this.Payment.Location = new System.Drawing.Point(11, 242);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(280, 21);
            this.Payment.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(351, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 172);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о услуге";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Несовершеннолетний",
            "Взрослый",
            "Пожилой(от 65)"});
            this.comboBox2.Location = new System.Drawing.Point(28, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(280, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Направление";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Несовершеннолетний",
            "Взрослый",
            "Пожилой(от 65)"});
            this.comboBox3.Location = new System.Drawing.Point(28, 82);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(280, 21);
            this.comboBox3.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Возрастная категория";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Несовершеннолетний",
            "Взрослый",
            "Пожилой(от 65)"});
            this.comboBox4.Location = new System.Drawing.Point(28, 129);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(280, 21);
            this.comboBox4.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Возрастная категория";
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Direction);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Add);
            this.Name = "AddClient";
            this.Text = "Добавить клиента";
            this.Direction.ResumeLayout(false);
            this.Direction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox Direction;
        private System.Windows.Forms.ComboBox DirectionName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Service;
        private System.Windows.Forms.Label Услуга;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AgeCategory;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameOfClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Payment;
        private System.Windows.Forms.ComboBox Decor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label12;
    }
}