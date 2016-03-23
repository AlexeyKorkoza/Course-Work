namespace CourseWork.Service
{
    partial class EditService
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CostService = new System.Windows.Forms.TextBox();
            this.Duration = new System.Windows.Forms.TextBox();
            this.NameService = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Direction = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.changeNameService = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewNameService = new System.Windows.Forms.TextBox();
            this.DirectionName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.Direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(201, 344);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 37);
            this.Cancel.TabIndex = 28;
            this.Cancel.Text = "Выйти";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(65, 344);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(96, 37);
            this.Edit.TabIndex = 27;
            this.Edit.Text = "Редактировать";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NewNameService);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.changeNameService);
            this.groupBox1.Controls.Add(this.CostService);
            this.groupBox1.Controls.Add(this.Duration);
            this.groupBox1.Controls.Add(this.NameService);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 231);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о услуге";
            // 
            // CostService
            // 
            this.CostService.Location = new System.Drawing.Point(28, 205);
            this.CostService.Name = "CostService";
            this.CostService.Size = new System.Drawing.Size(280, 20);
            this.CostService.TabIndex = 28;
            // 
            // Duration
            // 
            this.Duration.Location = new System.Drawing.Point(28, 156);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(280, 20);
            this.Duration.TabIndex = 27;
            // 
            // NameService
            // 
            this.NameService.Enabled = false;
            this.NameService.Location = new System.Drawing.Point(28, 43);
            this.NameService.Name = "NameService";
            this.NameService.Size = new System.Drawing.Size(280, 20);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Продолжительность";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Цена";
            // 
            // Direction
            // 
            this.Direction.Controls.Add(this.DirectionName);
            this.Direction.Controls.Add(this.label10);
            this.Direction.Location = new System.Drawing.Point(12, 12);
            this.Direction.Name = "Direction";
            this.Direction.Size = new System.Drawing.Size(333, 79);
            this.Direction.TabIndex = 25;
            this.Direction.TabStop = false;
            this.Direction.Text = "Информация о направлении";
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
            // changeNameService
            // 
            this.changeNameService.AutoSize = true;
            this.changeNameService.Location = new System.Drawing.Point(28, 69);
            this.changeNameService.Name = "changeNameService";
            this.changeNameService.Size = new System.Drawing.Size(136, 17);
            this.changeNameService.TabIndex = 29;
            this.changeNameService.Text = "Изменить имя услуги";
            this.changeNameService.UseVisualStyleBackColor = true;
            this.changeNameService.CheckedChanged += new System.EventHandler(this.changeNameService_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Новое название услуги";
            // 
            // NewNameService
            // 
            this.NewNameService.Enabled = false;
            this.NewNameService.Location = new System.Drawing.Point(28, 105);
            this.NewNameService.Name = "NewNameService";
            this.NewNameService.Size = new System.Drawing.Size(280, 20);
            this.NewNameService.TabIndex = 31;
            // 
            // DirectionName
            // 
            this.DirectionName.FormattingEnabled = true;
            this.DirectionName.Location = new System.Drawing.Point(28, 32);
            this.DirectionName.Name = "DirectionName";
            this.DirectionName.Size = new System.Drawing.Size(280, 21);
            this.DirectionName.TabIndex = 20;
            // 
            // EditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 393);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Direction);
            this.Name = "EditService";
            this.Text = "EditService";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Direction.ResumeLayout(false);
            this.Direction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CostService;
        private System.Windows.Forms.TextBox Duration;
        private System.Windows.Forms.TextBox NameService;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox Direction;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox changeNameService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewNameService;
        private System.Windows.Forms.ComboBox DirectionName;
    }
}