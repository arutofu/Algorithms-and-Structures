namespace TreeFormL
{
    partial class AddInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OkButton2 = new System.Windows.Forms.Button();
            this.KategoriaBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.TovarBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OkButton2);
            this.groupBox1.Controls.Add(this.KategoriaBox);
            this.groupBox1.Controls.Add(this.PhoneBox);
            this.groupBox1.Controls.Add(this.TovarBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // OkButton2
            // 
            this.OkButton2.Location = new System.Drawing.Point(6, 169);
            this.OkButton2.Name = "OkButton2";
            this.OkButton2.Size = new System.Drawing.Size(75, 23);
            this.OkButton2.TabIndex = 3;
            this.OkButton2.Text = "Ok";
            this.OkButton2.UseVisualStyleBackColor = true;
            this.OkButton2.Click += new System.EventHandler(this.OkButton2_Click);
            // 
            // KategoriaBox
            // 
            this.KategoriaBox.Location = new System.Drawing.Point(6, 111);
            this.KategoriaBox.Name = "KategoriaBox";
            this.KategoriaBox.Size = new System.Drawing.Size(233, 20);
            this.KategoriaBox.TabIndex = 2;
            this.KategoriaBox.Enter += new System.EventHandler(this.PostBox_Enter);
            this.KategoriaBox.Leave += new System.EventHandler(this.PostBox_Leave);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(6, 76);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(233, 20);
            this.PhoneBox.TabIndex = 1;
            this.PhoneBox.Enter += new System.EventHandler(this.TovarBox_Enter);
            this.PhoneBox.Leave += new System.EventHandler(this.TovarBox_Leave);
            // 
            // TovarBox
            // 
            this.TovarBox.Location = new System.Drawing.Point(6, 41);
            this.TovarBox.Name = "TovarBox";
            this.TovarBox.Size = new System.Drawing.Size(233, 20);
            this.TovarBox.TabIndex = 0;
            this.TovarBox.Enter += new System.EventHandler(this.ObiemBox_Enter);
            this.TovarBox.Leave += new System.EventHandler(this.ObiemBox_Leave);
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackButton.Location = new System.Drawing.Point(0, 214);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(271, 25);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 239);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button OkButton2;
        private System.Windows.Forms.TextBox KategoriaBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox TovarBox;
        private System.Windows.Forms.Button BackButton;
    }
}