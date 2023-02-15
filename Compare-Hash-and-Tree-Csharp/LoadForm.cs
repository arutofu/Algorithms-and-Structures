using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Main;
using System.IO;

namespace StructsCompare1
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
        }

        internal void HashSizeFromTXT()
        {
            int counter123 = 0;
            using (StreamReader newline = new StreamReader(GlobalVariables.numbFile, Encoding.UTF8))
            {
                String line;
                while ((line = newline.ReadLine()) != null)
                {
                    counter123++;
                }

                GlobalVariables.hashElemSize = counter123;
                GlobalVariables.hashSize = counter123;

                GlobalVariables.treeElemSize = counter123;
                GlobalVariables.treeSize = counter123;
            }
        }

        internal void TreeSizeFromTXT()
        {
            int counter321 = 0;
            using (StreamReader newline = new StreamReader(GlobalVariables.numbFile, Encoding.UTF8))
            {
                String line;
                while ((line = newline.ReadLine()) != null)
                {
                    counter321++;
                }
                GlobalVariables.treeElemSize = counter321;
                GlobalVariables.treeSize = counter321;
            }
        }


        private void LoadForm_Load(object sender, EventArgs e)
        {
            this.Hide();

            HashSizeFromTXT();
        //    TreeSizeFromTXT();

            Form1 main = new Form1();
            main.Show();



        }
    }
}
