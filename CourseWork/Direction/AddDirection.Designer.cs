namespace CourseWork.Direction
{
    partial class AddDirection
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
            this.Close = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.DirectionAdd = new System.Windows.Forms.GroupBox();
            this.DirectionName = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Услуга = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameService = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.Cost = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DirectionAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(200, 198);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(119, 34);
            this.Close.TabIndex = 13;
            this.Close.Text = "Выйти";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(41, 198);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 34);
            this.Add.TabIndex = 12;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // DirectionAdd
            // 
            this.DirectionAdd.Controls.Add(this.DirectionName);
            this.DirectionAdd.Controls.Add(this.Description);
            this.DirectionAdd.Controls.Add(this.label10);
            this.DirectionAdd.Controls.Add(this.Услуга);
            this.DirectionAdd.Location = new System.Drawing.Point(12, 12);
            this.DirectionAdd.Name = "DirectionAdd";
            this.DirectionAdd.Size = new System.Drawing.Size(333, 180);
            this.DirectionAdd.TabIndex = 15;
            this.DirectionAdd.TabStop = false;
            this.DirectionAdd.Text = "Информация о направлении";
            // 
            // DirectionName
            // 
            this.DirectionName.Location = new System.Drawing.Point(29, 43);
            this.DirectionName.Name = "DirectionName";
            this.DirectionName.Size = new System.Drawing.Size(278, 20);
            this.DirectionName.TabIndex = 22;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(27, 93);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(280, 61);
            this.Description.TabIndex = 21;
            this.Description.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Направление";
            // 
            // Услуга
            // 
            this.Услуга.AutoSize = true;
            this.Услуга.Location = new System.Drawing.Point(25, 77);
            this.Услуга.Name = "Услуга";
            this.Услуга.Size = new System.Drawing.Size(57, 13);
            this.Услуга.TabIndex = 17;
            this.Услуга.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Услуга";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Продолжительность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Цена";
            // 
            // NameService
            // 
            this.NameService.Location = new System.Drawing.Point(6, 32);
            this.NameService.Name = "NameService";
            this.NameService.Size = new System.Drawing.Size(254, 20);
            this.NameService.TabIndex = 19;
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(6, 83);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(254, 20);
            this.Duration.TabIndex = 20;
            this.Duration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Duration_KeyPress);
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(6, 134);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(254, 20);
            this.Cost.TabIndex = 21;
            this.Cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cost_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cost);
            this.groupBox1.Controls.Add(this.NameService);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(370, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 179);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о услуге";
            // 
            // AddDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 257);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DirectionAdd);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddDirection";
            this.Text = "Добавление направление";
            this.DirectionAdd.ResumeLayout(false);
            this.DirectionAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.GroupBox DirectionAdd;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Услуга;
        private System.Windows.Forms.TextBox DirectionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameService;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.TextBox Cost;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}