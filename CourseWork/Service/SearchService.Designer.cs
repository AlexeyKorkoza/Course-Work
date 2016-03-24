namespace CourseWork.Service
{
    partial class SearchService
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
            this.Search = new System.Windows.Forms.Button();
            this.DeleteService = new System.Windows.Forms.Button();
            this.datagridViewServices = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchStr = new System.Windows.Forms.TextBox();
            this.Functions = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewServices)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(217, 293);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 37);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Закрыть";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(121, 293);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(90, 37);
            this.Search.TabIndex = 20;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DeleteService
            // 
            this.DeleteService.Location = new System.Drawing.Point(13, 293);
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Size = new System.Drawing.Size(102, 37);
            this.DeleteService.TabIndex = 19;
            this.DeleteService.Text = "Удалить услугу";
            this.DeleteService.UseVisualStyleBackColor = true;
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
            this.datagridViewServices.Location = new System.Drawing.Point(12, 56);
            this.datagridViewServices.Name = "datagridViewServices";
            this.datagridViewServices.ReadOnly = true;
            this.datagridViewServices.RowHeadersVisible = false;
            this.datagridViewServices.Size = new System.Drawing.Size(584, 231);
            this.datagridViewServices.TabIndex = 18;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Строка поиска";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Критерий поиска";
            // 
            // SearchStr
            // 
            this.SearchStr.Location = new System.Drawing.Point(353, 30);
            this.SearchStr.Name = "SearchStr";
            this.SearchStr.Size = new System.Drawing.Size(243, 20);
            this.SearchStr.TabIndex = 23;
            // 
            // Functions
            // 
            this.Functions.FormattingEnabled = true;
            this.Functions.Items.AddRange(new object[] {
            "Id",
            "Название услуги",
            "Продолжительность",
            "Цена"});
            this.Functions.Location = new System.Drawing.Point(13, 29);
            this.Functions.Name = "Functions";
            this.Functions.Size = new System.Drawing.Size(279, 21);
            this.Functions.TabIndex = 22;
            // 
            // SearchService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 333);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchStr);
            this.Controls.Add(this.Functions);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.DeleteService);
            this.Controls.Add(this.datagridViewServices);
            this.Name = "SearchService";
            this.Text = "SearchService";
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button DeleteService;
        private System.Windows.Forms.DataGridView datagridViewServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchStr;
        private System.Windows.Forms.ComboBox Functions;
    }
}