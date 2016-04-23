namespace CourseWork.Discounts
{
    partial class ViewDiscounts
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
            this.dataGridViewDiscounts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hide = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.AddFromFile = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDiscounts
            // 
            this.dataGridViewDiscounts.AllowUserToAddRows = false;
            this.dataGridViewDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewDiscounts.Location = new System.Drawing.Point(12, 5);
            this.dataGridViewDiscounts.Name = "dataGridViewDiscounts";
            this.dataGridViewDiscounts.ReadOnly = true;
            this.dataGridViewDiscounts.RowHeadersVisible = false;
            this.dataGridViewDiscounts.Size = new System.Drawing.Size(204, 215);
            this.dataGridViewDiscounts.TabIndex = 0;
            this.dataGridViewDiscounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDiscounts_MouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Код скидки";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Размер скидки";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Hide
            // 
            this.Hide.Location = new System.Drawing.Point(237, 184);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(118, 36);
            this.Hide.TabIndex = 1;
            this.Hide.Text = "Закрыть";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(237, 113);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(118, 35);
            this.Search.TabIndex = 2;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(237, 72);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(118, 35);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(237, 34);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 32);
            this.Add.TabIndex = 4;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddFromFile
            // 
            this.AddFromFile.Location = new System.Drawing.Point(237, 5);
            this.AddFromFile.Name = "AddFromFile";
            this.AddFromFile.Size = new System.Drawing.Size(118, 23);
            this.AddFromFile.TabIndex = 5;
            this.AddFromFile.Text = "Добавить из файла";
            this.AddFromFile.UseVisualStyleBackColor = true;
            this.AddFromFile.Click += new System.EventHandler(this.AddFromFile_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(237, 154);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(118, 23);
            this.Refresh.TabIndex = 6;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ViewDiscounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 232);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.AddFromFile);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.dataGridViewDiscounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewDiscounts";
            this.Text = "Просмотр скидок";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDiscounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button AddFromFile;
        private System.Windows.Forms.Button Refresh;
    }
}