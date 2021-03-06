﻿namespace CourseWork.Direction
{
    partial class SearchDirection
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
            this.DeleteDirection = new System.Windows.Forms.Button();
            this.datagridViewDirections = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.Button();
            this.SearchStr = new System.Windows.Forms.TextBox();
            this.Functions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewDirections)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(247, 305);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(91, 37);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Закрыть";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DeleteDirection
            // 
            this.DeleteDirection.Location = new System.Drawing.Point(12, 305);
            this.DeleteDirection.Name = "DeleteDirection";
            this.DeleteDirection.Size = new System.Drawing.Size(129, 37);
            this.DeleteDirection.TabIndex = 14;
            this.DeleteDirection.Text = "Удалить направление";
            this.DeleteDirection.UseVisualStyleBackColor = true;
            this.DeleteDirection.Click += new System.EventHandler(this.DeleteDirection_Click);
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
            this.Column1});
            this.datagridViewDirections.Location = new System.Drawing.Point(14, 52);
            this.datagridViewDirections.Name = "datagridViewDirections";
            this.datagridViewDirections.ReadOnly = true;
            this.datagridViewDirections.RowHeadersVisible = false;
            this.datagridViewDirections.Size = new System.Drawing.Size(386, 247);
            this.datagridViewDirections.TabIndex = 12;
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
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(147, 305);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(94, 37);
            this.Search.TabIndex = 16;
            this.Search.Text = "Искать";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchStr
            // 
            this.SearchStr.Location = new System.Drawing.Point(226, 26);
            this.SearchStr.Name = "SearchStr";
            this.SearchStr.Size = new System.Drawing.Size(189, 20);
            this.SearchStr.TabIndex = 18;
            // 
            // Functions
            // 
            this.Functions.FormattingEnabled = true;
            this.Functions.Items.AddRange(new object[] {
            "Id",
            "Название направления",
            "Описание"});
            this.Functions.Location = new System.Drawing.Point(14, 25);
            this.Functions.Name = "Functions";
            this.Functions.Size = new System.Drawing.Size(206, 21);
            this.Functions.TabIndex = 17;
            this.Functions.SelectedIndexChanged += new System.EventHandler(this.Functions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Критерий поиска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Строка поиска";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 342);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchStr);
            this.Controls.Add(this.Functions);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DeleteDirection);
            this.Controls.Add(this.datagridViewDirections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SearchDirection";
            this.Text = "Поиск направления";
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewDirections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button DeleteDirection;
        private System.Windows.Forms.DataGridView datagridViewDirections;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchStr;
        private System.Windows.Forms.ComboBox Functions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button1;
    }
}