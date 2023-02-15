namespace TreeFormL
{
    partial class ShowInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowInfo));
            this.BackButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.CountGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriaGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackButton.Location = new System.Drawing.Point(0, 422);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(593, 25);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountGrid,
            this.NameGrid,
            this.PhoneGrid,
            this.KategoriaGrid,
            this.ParentGrid,
            this.LeftGrid,
            this.RightGrid});
            this.DataGrid.Location = new System.Drawing.Point(12, 12);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.Size = new System.Drawing.Size(569, 375);
            this.DataGrid.TabIndex = 2;
            // 
            // CountGrid
            // 
            this.CountGrid.HeaderText = "Count";
            this.CountGrid.Name = "CountGrid";
            this.CountGrid.ReadOnly = true;
            this.CountGrid.Width = 40;
            // 
            // NameGrid
            // 
            this.NameGrid.HeaderText = "Name";
            this.NameGrid.Name = "NameGrid";
            this.NameGrid.ReadOnly = true;
            this.NameGrid.Width = 160;
            // 
            // PhoneGrid
            // 
            this.PhoneGrid.HeaderText = "Phone";
            this.PhoneGrid.Name = "PhoneGrid";
            this.PhoneGrid.ReadOnly = true;
            this.PhoneGrid.Width = 85;
            // 
            // KategoriaGrid
            // 
            this.KategoriaGrid.HeaderText = "Kategoria";
            this.KategoriaGrid.Name = "KategoriaGrid";
            this.KategoriaGrid.ReadOnly = true;
            this.KategoriaGrid.Width = 60;
            // 
            // ParentGrid
            // 
            this.ParentGrid.HeaderText = "Parent";
            this.ParentGrid.Name = "ParentGrid";
            this.ParentGrid.ReadOnly = true;
            this.ParentGrid.Width = 60;
            // 
            // LeftGrid
            // 
            this.LeftGrid.HeaderText = "Left";
            this.LeftGrid.Name = "LeftGrid";
            this.LeftGrid.ReadOnly = true;
            this.LeftGrid.Width = 60;
            // 
            // RightGrid
            // 
            this.RightGrid.HeaderText = "Right";
            this.RightGrid.Name = "RightGrid";
            this.RightGrid.ReadOnly = true;
            this.RightGrid.Width = 60;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(12, 393);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 3;
            this.DelButton.Text = "Delete";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 447);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriaGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightGrid;
        private System.Windows.Forms.Button DelButton;
    }
}