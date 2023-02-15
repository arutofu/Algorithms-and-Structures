namespace Main
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchTree = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AllCompTree = new System.Windows.Forms.TextBox();
            this.AverageTree = new System.Windows.Forms.TextBox();
            this.GridTovar = new System.Windows.Forms.DataGridView();
            this.CountTree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IterTree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObiemTree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchNumber = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HashSizeLabel = new System.Windows.Forms.Label();
            this.SearchHash = new System.Windows.Forms.TextBox();
            this.HashNewSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HashSizeButton = new System.Windows.Forms.Button();
            this.GridPost = new System.Windows.Forms.DataGridView();
            this.CountHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IterHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObiemHash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageHash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AllCompHash = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTovar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPost)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchTree);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AllCompTree);
            this.groupBox2.Controls.Add(this.AverageTree);
            this.groupBox2.Controls.Add(this.GridTovar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(371, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 442);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "БДП";
            // 
            // SearchTree
            // 
            this.SearchTree.Location = new System.Drawing.Point(6, 338);
            this.SearchTree.Name = "SearchTree";
            this.SearchTree.ReadOnly = true;
            this.SearchTree.Size = new System.Drawing.Size(85, 20);
            this.SearchTree.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Поиск в БДП";
            // 
            // AllCompTree
            // 
            this.AllCompTree.Location = new System.Drawing.Point(7, 377);
            this.AllCompTree.Name = "AllCompTree";
            this.AllCompTree.ReadOnly = true;
            this.AllCompTree.Size = new System.Drawing.Size(85, 20);
            this.AllCompTree.TabIndex = 12;
            // 
            // AverageTree
            // 
            this.AverageTree.Location = new System.Drawing.Point(6, 416);
            this.AverageTree.Name = "AverageTree";
            this.AverageTree.ReadOnly = true;
            this.AverageTree.Size = new System.Drawing.Size(85, 20);
            this.AverageTree.TabIndex = 14;
            // 
            // GridTovar
            // 
            this.GridTovar.AllowUserToAddRows = false;
            this.GridTovar.AllowUserToDeleteRows = false;
            this.GridTovar.AllowUserToResizeColumns = false;
            this.GridTovar.AllowUserToResizeRows = false;
            this.GridTovar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridTovar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTovar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountTree,
            this.IterTree,
            this.ObiemTree});
            this.GridTovar.Location = new System.Drawing.Point(6, 19);
            this.GridTovar.Name = "GridTovar";
            this.GridTovar.ReadOnly = true;
            this.GridTovar.Size = new System.Drawing.Size(225, 287);
            this.GridTovar.TabIndex = 0;
            // 
            // CountTree
            // 
            this.CountTree.HeaderText = "";
            this.CountTree.Name = "CountTree";
            this.CountTree.ReadOnly = true;
            this.CountTree.Width = 40;
            // 
            // IterTree
            // 
            this.IterTree.HeaderText = "Сравнений";
            this.IterTree.Name = "IterTree";
            this.IterTree.ReadOnly = true;
            this.IterTree.Width = 70;
            // 
            // ObiemTree
            // 
            this.ObiemTree.HeaderText = "Ключ";
            this.ObiemTree.Name = "ObiemTree";
            this.ObiemTree.ReadOnly = true;
            this.ObiemTree.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Сравнений в ср.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Сравнений в БДП";
            // 
            // SearchNumber
            // 
            this.SearchNumber.Location = new System.Drawing.Point(7, 337);
            this.SearchNumber.Name = "SearchNumber";
            this.SearchNumber.Size = new System.Drawing.Size(75, 23);
            this.SearchNumber.TabIndex = 0;
            this.SearchNumber.Text = "Поиск";
            this.SearchNumber.Click += new System.EventHandler(this.SearchNumber_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.HashSizeLabel);
            this.groupBox1.Controls.Add(this.SearchHash);
            this.groupBox1.Controls.Add(this.HashNewSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.HashSizeButton);
            this.groupBox1.Controls.Add(this.GridPost);
            this.groupBox1.Controls.Add(this.AverageHash);
            this.groupBox1.Controls.Add(this.SearchNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AllCompHash);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 445);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ХТ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Задать размер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Поиск в ХТ";
            // 
            // HashSizeLabel
            // 
            this.HashSizeLabel.AutoSize = true;
            this.HashSizeLabel.Location = new System.Drawing.Point(88, 383);
            this.HashSizeLabel.Name = "HashSizeLabel";
            this.HashSizeLabel.Size = new System.Drawing.Size(0, 13);
            this.HashSizeLabel.TabIndex = 21;
            // 
            // SearchHash
            // 
            this.SearchHash.Location = new System.Drawing.Point(240, 341);
            this.SearchHash.Name = "SearchHash";
            this.SearchHash.ReadOnly = true;
            this.SearchHash.Size = new System.Drawing.Size(85, 20);
            this.SearchHash.TabIndex = 19;
            // 
            // HashNewSize
            // 
            this.HashNewSize.Location = new System.Drawing.Point(7, 419);
            this.HashNewSize.Name = "HashNewSize";
            this.HashNewSize.Size = new System.Drawing.Size(75, 20);
            this.HashNewSize.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Сравнений в ХТ";
            // 
            // HashSizeButton
            // 
            this.HashSizeButton.Location = new System.Drawing.Point(7, 378);
            this.HashSizeButton.Name = "HashSizeButton";
            this.HashSizeButton.Size = new System.Drawing.Size(75, 23);
            this.HashSizeButton.TabIndex = 19;
            this.HashSizeButton.Text = "Размер ХТ";
            this.HashSizeButton.UseVisualStyleBackColor = true;
            this.HashSizeButton.Click += new System.EventHandler(this.HashSizeButton_Click);
            // 
            // GridPost
            // 
            this.GridPost.AllowUserToAddRows = false;
            this.GridPost.AllowUserToDeleteRows = false;
            this.GridPost.AllowUserToResizeColumns = false;
            this.GridPost.AllowUserToResizeRows = false;
            this.GridPost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridPost.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountHash,
            this.Index1,
            this.Index2,
            this.IterHash,
            this.ObiemHash});
            this.GridPost.Location = new System.Drawing.Point(6, 19);
            this.GridPost.Name = "GridPost";
            this.GridPost.ReadOnly = true;
            this.GridPost.Size = new System.Drawing.Size(321, 290);
            this.GridPost.TabIndex = 1;
            // 
            // CountHash
            // 
            this.CountHash.HeaderText = "";
            this.CountHash.Name = "CountHash";
            this.CountHash.ReadOnly = true;
            this.CountHash.Width = 45;
            // 
            // Index1
            // 
            this.Index1.HeaderText = "Инд.1";
            this.Index1.Name = "Index1";
            this.Index1.ReadOnly = true;
            this.Index1.Width = 45;
            // 
            // Index2
            // 
            this.Index2.HeaderText = "Инд.2";
            this.Index2.Name = "Index2";
            this.Index2.ReadOnly = true;
            this.Index2.Width = 45;
            // 
            // IterHash
            // 
            this.IterHash.HeaderText = "Сравнений";
            this.IterHash.Name = "IterHash";
            this.IterHash.ReadOnly = true;
            this.IterHash.Width = 70;
            // 
            // ObiemHash
            // 
            this.ObiemHash.HeaderText = "Ключ";
            this.ObiemHash.Name = "ObiemHash";
            this.ObiemHash.ReadOnly = true;
            this.ObiemHash.Width = 50;
            // 
            // AverageHash
            // 
            this.AverageHash.Location = new System.Drawing.Point(240, 419);
            this.AverageHash.Name = "AverageHash";
            this.AverageHash.ReadOnly = true;
            this.AverageHash.Size = new System.Drawing.Size(85, 20);
            this.AverageHash.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Сравнений в ср.";
            // 
            // AllCompHash
            // 
            this.AllCompHash.Location = new System.Drawing.Point(240, 380);
            this.AllCompHash.Name = "AllCompHash";
            this.AllCompHash.ReadOnly = true;
            this.AllCompHash.Size = new System.Drawing.Size(85, 20);
            this.AllCompHash.TabIndex = 11;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(91, 337);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(621, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTovar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        protected internal System.Windows.Forms.DataGridView GridTovar;
        private System.Windows.Forms.Button SearchNumber;
        protected internal System.Windows.Forms.DataGridView GridPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn IterTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObiemTree;
        private System.Windows.Forms.TextBox AllCompHash;
        private System.Windows.Forms.TextBox AllCompTree;
        private System.Windows.Forms.TextBox AverageHash;
        private System.Windows.Forms.TextBox AverageTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IterHash;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObiemHash;
        private System.Windows.Forms.TextBox SearchHash;
        private System.Windows.Forms.TextBox SearchTree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HashNewSize;
        private System.Windows.Forms.Button HashSizeButton;
        internal System.Windows.Forms.Label HashSizeLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddButton;
    }
}

