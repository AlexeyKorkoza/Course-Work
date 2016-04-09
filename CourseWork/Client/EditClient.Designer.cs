namespace CourseWork.Client
{
    partial class EditClient
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
            this.Payment = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Visit = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.NameService = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CostService = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.DescriptionDiscount = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Decor = new System.Windows.Forms.ComboBox();
            this.Client = new System.Windows.Forms.GroupBox();
            this.NameOfClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.AgeCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Direction = new System.Windows.Forms.GroupBox();
            this.DirectionDescription = new System.Windows.Forms.RichTextBox();
            this.DirectionName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Услуга = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Discount.SuspendLayout();
            this.Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // Payment
            // 
            this.Payment.FormattingEnabled = true;
            this.Payment.Items.AddRange(new object[] {
            "Наличный",
            "Безналичный"});
            this.Payment.Location = new System.Drawing.Point(11, 269);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(280, 21);
            this.Payment.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Visit);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.NameService);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CostService);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(378, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 206);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о услуге";
            // 
            // Visit
            // 
            this.Visit.FormattingEnabled = true;
            this.Visit.Items.AddRange(new object[] {
            "Одноразовое",
            "Многоразовое"});
            this.Visit.Location = new System.Drawing.Point(28, 179);
            this.Visit.Name = "Visit";
            this.Visit.Size = new System.Drawing.Size(280, 21);
            this.Visit.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Количество посещений";
            // 
            // NameService
            // 
            this.NameService.FormattingEnabled = true;
            this.NameService.Location = new System.Drawing.Point(28, 39);
            this.NameService.Name = "NameService";
            this.NameService.Size = new System.Drawing.Size(280, 21);
            this.NameService.TabIndex = 26;
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
            // Duration
            // 
            this.Duration.FormattingEnabled = true;
            this.Duration.Location = new System.Drawing.Point(28, 82);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(280, 21);
            this.Duration.TabIndex = 24;
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
            // CostService
            // 
            this.CostService.FormattingEnabled = true;
            this.CostService.Location = new System.Drawing.Point(28, 129);
            this.CostService.Name = "CostService";
            this.CostService.Size = new System.Drawing.Size(280, 21);
            this.CostService.TabIndex = 22;
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
            this.Discount.Controls.Add(this.monthCalendar1);
            this.Discount.Controls.Add(this.DescriptionDiscount);
            this.Discount.Controls.Add(this.label14);
            this.Discount.Controls.Add(this.Size);
            this.Discount.Controls.Add(this.label13);
            this.Discount.Controls.Add(this.Code);
            this.Discount.Controls.Add(this.label8);
            this.Discount.Location = new System.Drawing.Point(39, 377);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(672, 116);
            this.Discount.TabIndex = 22;
            this.Discount.TabStop = false;
            this.Discount.Text = "Информация о скидке";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(66, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            this.monthCalendar1.Visible = false;
            // 
            // DescriptionDiscount
            // 
            this.DescriptionDiscount.Location = new System.Drawing.Point(322, 32);
            this.DescriptionDiscount.Name = "DescriptionDiscount";
            this.DescriptionDiscount.Size = new System.Drawing.Size(280, 70);
            this.DescriptionDiscount.TabIndex = 32;
            this.DescriptionDiscount.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Описание";
            // 
            // Size
            // 
            this.Size.FormattingEnabled = true;
            this.Size.Location = new System.Drawing.Point(11, 81);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(280, 21);
            this.Size.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 65);
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
            // Decor
            // 
            this.Decor.FormattingEnabled = true;
            this.Decor.Items.AddRange(new object[] {
            "По телефону",
            "По прибытию"});
            this.Decor.Location = new System.Drawing.Point(11, 316);
            this.Decor.Name = "Decor";
            this.Decor.Size = new System.Drawing.Size(280, 21);
            this.Decor.TabIndex = 20;
            // 
            // Client
            // 
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
            this.Client.Location = new System.Drawing.Point(39, 2);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(322, 369);
            this.Client.TabIndex = 19;
            this.Client.TabStop = false;
            this.Client.Text = "Информация о клиенте";
            // 
            // NameOfClient
            // 
            this.NameOfClient.Location = new System.Drawing.Point(11, 93);
            this.NameOfClient.Name = "NameOfClient";
            this.NameOfClient.Size = new System.Drawing.Size(280, 20);
            this.NameOfClient.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Имя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources._73e1bc97_2118_4e96_9366_a609b5c6f271;
            this.pictureBox1.Location = new System.Drawing.Point(297, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Оформление заказа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Способ оплаты";
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(9, 52);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(280, 20);
            this.Lastname.TabIndex = 1;
            // 
            // AgeCategory
            // 
            this.AgeCategory.FormattingEnabled = true;
            this.AgeCategory.Items.AddRange(new object[] {
            "Несовершеннолетний",
            "Взрослый",
            "Пожилой(от 65)"});
            this.AgeCategory.Location = new System.Drawing.Point(11, 229);
            this.AgeCategory.Name = "AgeCategory";
            this.AgeCategory.Size = new System.Drawing.Size(280, 21);
            this.AgeCategory.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Возрастная категория";
            // 
            // Middlename
            // 
            this.Middlename.Location = new System.Drawing.Point(11, 132);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(280, 20);
            this.Middlename.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата";
            // 
            // Date
            // 
            this.Date.Enabled = false;
            this.Date.Location = new System.Drawing.Point(11, 183);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(280, 20);
            this.Date.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // Direction
            // 
            this.Direction.Controls.Add(this.DirectionDescription);
            this.Direction.Controls.Add(this.DirectionName);
            this.Direction.Controls.Add(this.label10);
            this.Direction.Controls.Add(this.Услуга);
            this.Direction.Location = new System.Drawing.Point(378, 2);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(333, 152);
            this.Direction.TabIndex = 20;
            this.Direction.TabStop = false;
            this.Direction.Text = "Информация о направлении";
            // 
            // DirectionDescription
            // 
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
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(421, 499);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(93, 39);
            this.Cancel.TabIndex = 24;
            this.Cancel.Text = "Выйти";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(315, 499);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(89, 39);
            this.Update.TabIndex = 25;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 550);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.Direction);
            this.Name = "EditClient";
            this.Text = "Редактирование клиента";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Discount.ResumeLayout(false);
            this.Discount.PerformLayout();
            this.Client.ResumeLayout(false);
            this.Client.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Direction.ResumeLayout(false);
            this.Direction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Payment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Visit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox NameService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Duration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CostService;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Discount;
        private System.Windows.Forms.RichTextBox DescriptionDiscount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox Size;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Code;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox Decor;
        private System.Windows.Forms.GroupBox Client;
        private System.Windows.Forms.TextBox NameOfClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.ComboBox AgeCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Direction;
        private System.Windows.Forms.RichTextBox DirectionDescription;
        private System.Windows.Forms.ComboBox DirectionName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Услуга;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Update;
    }
}