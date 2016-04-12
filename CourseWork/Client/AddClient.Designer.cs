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
            this.DirectionDescription = new System.Windows.Forms.RichTextBox();
            this.DirectionName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Услуга = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AgeCategory = new System.Windows.Forms.ComboBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Client = new System.Windows.Forms.GroupBox();
            this.Visit = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.ComboBox();
            this.Decor = new System.Windows.Forms.ComboBox();
            this.NameOfClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameService = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.CostService = new System.Windows.Forms.TextBox();
            this.Direction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Client.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Discount.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(240, 477);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 34);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(334, 477);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 34);
            this.Close.TabIndex = 11;
            this.Close.Text = "Выйти";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(121, 155);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // Direction
            // 
            this.Direction.Controls.Add(this.DirectionDescription);
            this.Direction.Controls.Add(this.DirectionName);
            this.Direction.Controls.Add(this.label10);
            this.Direction.Controls.Add(this.Услуга);
            this.Direction.Location = new System.Drawing.Point(351, 12);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(333, 152);
            this.Direction.TabIndex = 14;
            this.Direction.TabStop = false;
            this.Direction.Text = "Информация о направлении";
            // 
            // DirectionDescription
            // 
            this.DirectionDescription.Enabled = false;
            this.DirectionDescription.Location = new System.Drawing.Point(28, 75);
            this.DirectionDescription.Name = "DirectionDescription";
            this.DirectionDescription.Size = new System.Drawing.Size(280, 61);
            this.DirectionDescription.TabIndex = 21;
            this.DirectionDescription.Text = "";
            // 
            // DirectionName
            // 
            this.DirectionName.FormattingEnabled = true;
            this.DirectionName.Location = new System.Drawing.Point(28, 32);
            this.DirectionName.Name = "DirectionName";
            this.DirectionName.Size = new System.Drawing.Size(280, 21);
            this.DirectionName.TabIndex = 20;
            this.DirectionName.SelectedIndexChanged += new System.EventHandler(this.DirectionName_SelectedIndexChanged);
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
            // Услуга
            // 
            this.Услуга.AutoSize = true;
            this.Услуга.Location = new System.Drawing.Point(25, 59);
            this.Услуга.Name = "Услуга";
            this.Услуга.Size = new System.Drawing.Size(57, 13);
            this.Услуга.TabIndex = 17;
            this.Услуга.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
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
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата";
            // 
            // Middlename
            // 
            this.Middlename.Location = new System.Drawing.Point(9, 116);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(280, 20);
            this.Middlename.TabIndex = 5;
            this.Middlename.TextChanged += new System.EventHandler(this.Middlename_TextChanged);
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
            this.AgeCategory.Location = new System.Drawing.Point(11, 202);
            this.AgeCategory.Name = "AgeCategory";
            this.AgeCategory.Size = new System.Drawing.Size(280, 21);
            this.AgeCategory.TabIndex = 12;
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(9, 33);
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
            this.Client.Controls.Add(this.Visit);
            this.Client.Controls.Add(this.monthCalendar1);
            this.Client.Controls.Add(this.label15);
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
            this.Client.Controls.Add(this.label16);
            this.Client.Controls.Add(this.Middlename);
            this.Client.Controls.Add(this.label4);
            this.Client.Controls.Add(this.Date);
            this.Client.Controls.Add(this.label3);
            this.Client.Location = new System.Drawing.Point(12, 12);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(322, 369);
            this.Client.TabIndex = 13;
            this.Client.TabStop = false;
            this.Client.Text = "Информация о клиенте";
            // 
            // Visit
            // 
            this.Visit.FormattingEnabled = true;
            this.Visit.Items.AddRange(new object[] {
            "Одноразовое",
            "Многоразовое"});
            this.Visit.Location = new System.Drawing.Point(9, 342);
            this.Visit.Name = "Visit";
            this.Visit.Size = new System.Drawing.Size(280, 21);
            this.Visit.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 326);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Количество посещений";
            // 
            // Payment
            // 
            this.Payment.FormattingEnabled = true;
            this.Payment.Items.AddRange(new object[] {
            "Наличный",
            "Безналичный"});
            this.Payment.Location = new System.Drawing.Point(9, 245);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(280, 21);
            this.Payment.TabIndex = 21;
            // 
            // Decor
            // 
            this.Decor.FormattingEnabled = true;
            this.Decor.Items.AddRange(new object[] {
            "По телефону",
            "По прибытию"});
            this.Decor.Location = new System.Drawing.Point(11, 296);
            this.Decor.Name = "Decor";
            this.Decor.Size = new System.Drawing.Size(280, 21);
            this.Decor.TabIndex = 20;
            // 
            // NameOfClient
            // 
            this.NameOfClient.Location = new System.Drawing.Point(9, 75);
            this.NameOfClient.Name = "NameOfClient";
            this.NameOfClient.Size = new System.Drawing.Size(280, 20);
            this.NameOfClient.TabIndex = 19;
            this.NameOfClient.TextChanged += new System.EventHandler(this.NameOfClient_TextChanged);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Оформление заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Способ оплаты";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Возрастная категория";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CostService);
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.NameService);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(351, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 174);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о услуге";
            // 
            // NameService
            // 
            this.NameService.FormattingEnabled = true;
            this.NameService.Location = new System.Drawing.Point(28, 39);
            this.NameService.Name = "NameService";
            this.NameService.Size = new System.Drawing.Size(280, 21);
            this.NameService.TabIndex = 26;
            this.NameService.SelectedIndexChanged += new System.EventHandler(this.NameService_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Название услуги";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Продолжительность";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Цена";
            // 
            // Discount
            // 
            this.Discount.Controls.Add(this.Size);
            this.Discount.Controls.Add(this.label13);
            this.Discount.Controls.Add(this.Code);
            this.Discount.Controls.Add(this.label8);
            this.Discount.Location = new System.Drawing.Point(12, 399);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(672, 72);
            this.Discount.TabIndex = 16;
            this.Discount.TabStop = false;
            this.Discount.Text = "Информация о скидке";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(336, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Размер";
            // 
            // Code
            // 
            this.Code.FormattingEnabled = true;
            this.Code.Location = new System.Drawing.Point(11, 32);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(280, 21);
            this.Code.TabIndex = 28;
            this.Code.SelectedIndexChanged += new System.EventHandler(this.Code_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Код";
            // 
            // Size
            // 
            this.Size.Enabled = false;
            this.Size.Location = new System.Drawing.Point(339, 32);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(280, 20);
            this.Size.TabIndex = 31;
            this.Size.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Duration
            // 
            this.Duration.Enabled = false;
            this.Duration.Location = new System.Drawing.Point(28, 83);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(280, 20);
            this.Duration.TabIndex = 27;
            // 
            // CostService
            // 
            this.CostService.Enabled = false;
            this.CostService.Location = new System.Drawing.Point(28, 122);
            this.CostService.Name = "CostService";
            this.CostService.Size = new System.Drawing.Size(280, 20);
            this.CostService.TabIndex = 28;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 518);
            this.Controls.Add(this.Discount);
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
            this.Discount.ResumeLayout(false);
            this.Discount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox Direction;
        private System.Windows.Forms.ComboBox DirectionName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Услуга;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Middlename;
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
        private System.Windows.Forms.ComboBox NameService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox DirectionDescription;
        private System.Windows.Forms.GroupBox Discount;
        private System.Windows.Forms.ComboBox Code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Visit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.TextBox CostService;
    }
}