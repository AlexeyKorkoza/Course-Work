namespace CourseWork.Direction
{
    partial class DeleteDirection
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
            this.DirectionName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DirectionName
            // 
            this.DirectionName.FormattingEnabled = true;
            this.DirectionName.Location = new System.Drawing.Point(12, 38);
            this.DirectionName.Name = "DirectionName";
            this.DirectionName.Size = new System.Drawing.Size(260, 21);
            this.DirectionName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите направление";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 75);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 32);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(188, 75);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 32);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Выйти";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(93, 75);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(89, 32);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // DeleteDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DirectionName);
            this.Name = "DeleteDirection";
            this.Text = "DeleteDirection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DirectionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Refresh;
    }
}