namespace CourseWork
{
    partial class Settings
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
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.oldpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 125);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(128, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Сменить пароль";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(158, 125);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(114, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // oldpassword
            // 
            this.oldpassword.Location = new System.Drawing.Point(12, 41);
            this.oldpassword.Name = "oldpassword";
            this.oldpassword.Size = new System.Drawing.Size(260, 20);
            this.oldpassword.TabIndex = 2;
            this.oldpassword.TextChanged += new System.EventHandler(this.oldpassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите старый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите новый пароль";
            // 
            // newpassword
            // 
            this.newpassword.Location = new System.Drawing.Point(12, 90);
            this.newpassword.Name = "newpassword";
            this.newpassword.Size = new System.Drawing.Size(260, 20);
            this.newpassword.TabIndex = 4;
            this.newpassword.TextChanged += new System.EventHandler(this.newpassword_TextChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldpassword);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Name = "Settings";
            this.Text = "Настройка пароля";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox oldpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newpassword;
    }
}