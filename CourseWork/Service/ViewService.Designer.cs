namespace CourseWork.Service
{
    partial class ViewService
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
            this.Refresh = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.DeleteService = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.datagridViewServices = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileExtension = new System.Windows.Forms.Button();
            this.inputServices = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(484, 203);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 37);
            this.Cancel.TabIndex = 17;
            this.Cancel.Text = "Закрыть";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(381, 203);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 37);
            this.Refresh.TabIndex = 16;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(265, 203);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(90, 37);
            this.Search.TabIndex = 15;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DeleteService
            // 
            this.DeleteService.Location = new System.Drawing.Point(141, 203);
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Size = new System.Drawing.Size(102, 37);
            this.DeleteService.TabIndex = 14;
            this.DeleteService.Text = "Удалить услугу";
            this.DeleteService.UseVisualStyleBackColor = true;
            this.DeleteService.Click += new System.EventHandler(this.DeleteService_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Добавить услугу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // datagridViewServices
            // 
            this.datagridViewServices.AllowUserToAddRows = false;
            this.datagridViewServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column6,
            this.Column1,
            this.Column3,
            this.Column4});
            this.datagridViewServices.Location = new System.Drawing.Point(12, 12);
            this.datagridViewServices.Name = "datagridViewServices";
            this.datagridViewServices.ReadOnly = true;
            this.datagridViewServices.RowHeadersVisible = false;
            this.datagridViewServices.Size = new System.Drawing.Size(584, 179);
            this.datagridViewServices.TabIndex = 12;
            this.datagridViewServices.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.datagridViewServices_MouseDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Название направления";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 180;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название услуги";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Продолжительность";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Цена";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FileExtension
            // 
            this.FileExtension.Location = new System.Drawing.Point(582, 203);
            this.FileExtension.Name = "FileExtension";
            this.FileExtension.Size = new System.Drawing.Size(111, 37);
            this.FileExtension.TabIndex = 18;
            this.FileExtension.Text = "Добавить услугу из файла";
            this.FileExtension.UseVisualStyleBackColor = true;
            this.FileExtension.Click += new System.EventHandler(this.FileExtension_Click);
            // 
            // inputServices
            // 
            this.inputServices.FileName = "inputServices";
            // 
            // ViewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 261);
            this.Controls.Add(this.FileExtension);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DeleteService);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datagridViewServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ViewService";
            this.Text = "Просмотр услуг";
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button DeleteService;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView datagridViewServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button FileExtension;
        private System.Windows.Forms.OpenFileDialog inputServices;
    }
}