namespace TreeFormL
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.AddFileRadio = new System.Windows.Forms.RadioButton();
            this.SeeInfoRadio = new System.Windows.Forms.RadioButton();
            this.AddInfoRadio = new System.Windows.Forms.RadioButton();
            this.OkButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox);
            this.groupBox1.Controls.Add(this.AddFileRadio);
            this.groupBox1.Controls.Add(this.SeeInfoRadio);
            this.groupBox1.Controls.Add(this.AddInfoRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(6, 32);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.ShortcutsEnabled = false;
            this.textBox.Size = new System.Drawing.Size(227, 20);
            this.textBox.TabIndex = 3;
            this.textBox.TabStop = false;
            this.textBox.Text = "Здесь будет указан путь к файлу";
            // 
            // AddFileRadio
            // 
            this.AddFileRadio.AutoSize = true;
            this.AddFileRadio.Enabled = false;
            this.AddFileRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFileRadio.Location = new System.Drawing.Point(5, 81);
            this.AddFileRadio.Name = "AddFileRadio";
            this.AddFileRadio.Size = new System.Drawing.Size(112, 19);
            this.AddFileRadio.TabIndex = 1;
            this.AddFileRadio.TabStop = true;
            this.AddFileRadio.Text = "Выбрать файл";
            this.AddFileRadio.UseVisualStyleBackColor = true;
            // 
            // SeeInfoRadio
            // 
            this.SeeInfoRadio.AutoSize = true;
            this.SeeInfoRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeeInfoRadio.Location = new System.Drawing.Point(6, 131);
            this.SeeInfoRadio.Name = "SeeInfoRadio";
            this.SeeInfoRadio.Size = new System.Drawing.Size(163, 19);
            this.SeeInfoRadio.TabIndex = 2;
            this.SeeInfoRadio.TabStop = true;
            this.SeeInfoRadio.Text = "Просмотр информации";
            this.SeeInfoRadio.UseVisualStyleBackColor = true;
            // 
            // AddInfoRadio
            // 
            this.AddInfoRadio.AutoSize = true;
            this.AddInfoRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddInfoRadio.Location = new System.Drawing.Point(5, 106);
            this.AddInfoRadio.Name = "AddInfoRadio";
            this.AddInfoRadio.Size = new System.Drawing.Size(164, 19);
            this.AddInfoRadio.TabIndex = 1;
            this.AddInfoRadio.TabStop = true;
            this.AddInfoRadio.Text = "Добавить информацию";
            this.AddInfoRadio.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OkButton.Location = new System.Drawing.Point(0, 187);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(263, 25);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 212);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SeeInfoRadio;
        private System.Windows.Forms.RadioButton AddInfoRadio;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton AddFileRadio;
        private System.Windows.Forms.TextBox textBox;
    }
}

