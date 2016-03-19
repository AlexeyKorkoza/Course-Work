namespace CourseWork.Direction
{
    partial class ViewDirection
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
            this.datagridViewDirections = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDirection = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.DeleteService = new System.Windows.Forms.Button();
            this.DeleteDirection = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewDirections)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridViewDirections
            // 
            this.datagridViewDirections.AllowUserToAddRows = false;
            this.datagridViewDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridViewDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridViewDirections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column6,
            this.Column1,
            this.Column8,
            this.Column9,
            this.Column10});
            this.datagridViewDirections.Location = new System.Drawing.Point(12, 25);
            this.datagridViewDirections.Name = "datagridViewDirections";
            this.datagridViewDirections.ReadOnly = true;
            this.datagridViewDirections.RowHeadersVisible = false;
            this.datagridViewDirections.Size = new System.Drawing.Size(823, 179);
            this.datagridViewDirections.TabIndex = 4;
            this.datagridViewDirections.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.datagridViewDirections_MouseDoubleClick);
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
            this.Column1.HeaderText = "Описание";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Название услуги";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 180;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Продолжительность";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 160;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Цена";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // AddDirection
            // 
            this.AddDirection.Location = new System.Drawing.Point(12, 216);
            this.AddDirection.Name = "AddDirection";
            this.AddDirection.Size = new System.Drawing.Size(97, 37);
            this.AddDirection.TabIndex = 5;
            this.AddDirection.Text = "Добавить направление";
            this.AddDirection.UseVisualStyleBackColor = true;
            this.AddDirection.Click += new System.EventHandler(this.AddDirection_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Добавить услугу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeleteService
            // 
            this.DeleteService.Location = new System.Drawing.Point(282, 216);
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Size = new System.Drawing.Size(102, 37);
            this.DeleteService.TabIndex = 7;
            this.DeleteService.Text = "Удалить услугу";
            this.DeleteService.UseVisualStyleBackColor = true;
            this.DeleteService.Click += new System.EventHandler(this.DeleteService_Click);
            // 
            // DeleteDirection
            // 
            this.DeleteDirection.Location = new System.Drawing.Point(418, 216);
            this.DeleteDirection.Name = "DeleteDirection";
            this.DeleteDirection.Size = new System.Drawing.Size(112, 37);
            this.DeleteDirection.TabIndex = 8;
            this.DeleteDirection.Text = "Удалить направление";
            this.DeleteDirection.UseVisualStyleBackColor = true;
            this.DeleteDirection.Click += new System.EventHandler(this.DeleteDirection_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(553, 216);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(90, 37);
            this.Search.TabIndex = 9;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(662, 216);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 37);
            this.Refresh.TabIndex = 10;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(760, 216);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 33);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Закрыть";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ViewDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 261);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DeleteDirection);
            this.Controls.Add(this.DeleteService);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddDirection);
            this.Controls.Add(this.datagridViewDirections);
            this.Name = "ViewDirection";
            this.Text = "ViewDirection";
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewDirections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridViewDirections;
        private System.Windows.Forms.Button AddDirection;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button DeleteService;
        private System.Windows.Forms.Button DeleteDirection;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button Cancel;

    }
}