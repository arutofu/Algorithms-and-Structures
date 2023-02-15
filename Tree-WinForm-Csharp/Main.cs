using DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeFormL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.File_Path = @"TextTree.txt";

            if (Properties.Settings.Default.File_Path != "")
            {
                FilePath.filepath = Properties.Settings.Default.File_Path;
                if (Properties.Settings.Default.Sklad_Size != 0)
                {
                    int iter = 0;
                    using (StreamReader newline = new StreamReader(FilePath.filepath, Encoding.UTF8))
                    {
                        String line;
                        while ((line = newline.ReadLine()) != null)
                        {
                            iter++;
                        }
                        Properties.Settings.Default.Sklad_Size = iter;
                        Properties.Settings.Default.Save();
                    }
                    textBox.Text = Properties.Settings.Default.File_Path;
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (AddInfoRadio.Checked)
            {
                if (FilePath.filepath != null)
                {
                    this.Hide();
                    AddInfo addinfoform = new AddInfo();
                    addinfoform.Owner = this;
                    addinfoform.Show();
                }
                else MessageBox.Show("Для работы программы выберите файл");

            }
            if (SeeInfoRadio.Checked)
            {
                if (FilePath.filepath != null)
                {
                    this.Hide();
                    ShowInfo showinfoform = new ShowInfo();
                    showinfoform.Owner = this;
                    showinfoform.Show();
                }
                else MessageBox.Show("Для работы программы выберите файл");
            }
            if (AddFileRadio.Checked)
            {
                using (OpenFileDialog openDialog = new OpenFileDialog())
                {
                    openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    openDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Документ Word (*.docx)|*.docx";
                    if (openDialog.ShowDialog(this) == DialogResult.OK)
                    {
                        try
                        {
                            FilePath.filepath = openDialog.FileName;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    Properties.Settings.Default.File_Path = openDialog.FileName; // сохраняет путь к файлу
                    Properties.Settings.Default.Save();
                }
            }
            try
            {
                int iter = 0;
                using (StreamReader newline = new StreamReader(FilePath.filepath, Encoding.UTF8))
                {
                    String line;
                    while ((line = newline.ReadLine()) != null)
                    {
                        iter++;
                    }

                    Properties.Settings.Default.Sklad_Size = iter;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
