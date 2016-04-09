namespace CourseWork.Direction
{
    partial class EditDirection
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
            this.DirectionAdd = new System.Windows.Forms.GroupBox();
            this.DirectionName = new System.Windows.Forms.ComboBox();
            this.ChangeDirectionName = new System.Windows.Forms.CheckBox();
            this.NewDirection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Услуга = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.DirectionAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // DirectionAdd
            // 
            this.DirectionAdd.Controls.Add(this.DirectionName);
            this.DirectionAdd.Controls.Add(this.ChangeDirectionName);
            this.DirectionAdd.Controls.Add(this.NewDirection);
            this.DirectionAdd.Controls.Add(this.label1);
            this.DirectionAdd.Controls.Add(this.Description);
            this.DirectionAdd.Controls.Add(this.label10);
            this.DirectionAdd.Controls.Add(this.Услуга);
            this.DirectionAdd.Location = new System.Drawing.Point(25, 16);
            this.DirectionAdd.Name = "DirectionAdd";
            this.DirectionAdd.Size = new System.Drawing.Size(333, 203);
            this.DirectionAdd.TabIndex = 19;
            this.DirectionAdd.TabStop = false;
            this.DirectionAdd.Text = "Информация о направлении";
            // 
            // DirectionName
            // 
            this.DirectionName.FormattingEnabled = true;
            this.DirectionName.Location = new System.Drawing.Point(29, 48);
            this.DirectionName.Name = "DirectionName";
            this.DirectionName.Size = new System.Drawing.Size(280, 21);
            this.DirectionName.TabIndex = 26;
            this.DirectionName.SelectedIndexChanged += new System.EventHandler(this.DirectionName_SelectedIndexChanged);
            // 
            // ChangeDirectionName
            // 
            this.ChangeDirectionName.AutoSize = true;
            this.ChangeDirectionName.Location = new System.Drawing.Point(130, 20);
            this.ChangeDirectionName.Name = "ChangeDirectionName";
            this.ChangeDirectionName.Size = new System.Drawing.Size(197, 17);
            this.ChangeDirectionName.TabIndex = 25;
            this.ChangeDirectionName.Text = "Изменить название направления";
            this.ChangeDirectionName.UseVisualStyleBackColor = true;
            this.ChangeDirectionName.CheckedChanged += new System.EventHandler(this.ChangeDirectionName_CheckedChanged);
            // 
            // NewDirection
            // 
            this.NewDirection.Enabled = false;
            this.NewDirection.Location = new System.Drawing.Point(29, 88);
            this.NewDirection.Name = "NewDirection";
            this.NewDirection.Size = new System.Drawing.Size(278, 20);
            this.NewDirection.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Новое название направления";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(29, 136);
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
            this.Услуга.Location = new System.Drawing.Point(26, 111);
            this.Услуга.Name = "Услуга";
            this.Услуга.Size = new System.Drawing.Size(57, 13);
            this.Услуга.TabIndex = 17;
            this.Услуга.Text = "Описание";
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(283, 225);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 34);
            this.Close.TabIndex = 18;
            this.Close.Text = "Выйти";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(25, 225);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 34);
            this.Add.TabIndex = 17;
            this.Add.Text = "Редактировать";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(155, 225);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(96, 34);
            this.Refresh.TabIndex = 20;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // EditDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 261);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.DirectionAdd);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Add);
            this.Name = "EditDirection";
            this.Text = "Редактирования направления";
            this.DirectionAdd.ResumeLayout(false);
            this.DirectionAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DirectionAdd;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Услуга;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox NewDirection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChangeDirectionName;
        private System.Windows.Forms.ComboBox DirectionName;
        private System.Windows.Forms.Button Refresh;
    }
}