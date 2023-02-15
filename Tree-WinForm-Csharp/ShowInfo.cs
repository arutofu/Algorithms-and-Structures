using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using DataClass;


namespace TreeFormL
{
    public partial class ShowInfo : Form
    {
        public ShowInfo()
        {
            InitializeComponent();
        }

        TreeRoot tree = new TreeRoot();
        TreeRoot.InsertNode insnode = new TreeRoot.InsertNode();

        private void Form3_Load(object sender, EventArgs e)
        {
            SkladData[] array = new SkladData[Properties.Settings.Default.Sklad_Size];
            using (StreamReader reader = new StreamReader(FilePath.filepath, Encoding.UTF8))
            {
                DataGrid.Rows.Add(Properties.Settings.Default.Sklad_Size);
                for (int i = 0; i < array.Length; i++)
                {
                    int Count = i + 1;
                    string[] words = reader.ReadLine().Split('/');

                    array[i] = new SkladData
                    {
                        Tovar = Convert.ToString(words[0]),
                        Phone = Convert.ToString(words[1]),
                        Kategoria = Convert.ToInt16(words[2])
                    };
                    insnode.Tovar = array[i].Tovar;
                    insnode.Phone = array[i].Phone;
                    insnode.Key = array[i].Kategoria;
                    try
                    {
                        tree.Insert(insnode.Tovar, insnode.Phone, insnode.Key);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    DataGrid.Rows[i].Cells[0].Value = Count;
                    DataGrid.Rows[i].Cells[3].Value = insnode.Key;
                }
                void Find(TreeRoot mynode) //---------------- ВЫВОД НА ФОРМУ ----
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        int count = 0;
                        if (mynode != null)
                        {
                            while ((int)DataGrid.Rows[count].Cells[3].Value != mynode.Key)
                            {
                                count++;
                            }
                            DataGrid.Rows[count].Cells[1].Value = mynode.Tovar;
                            DataGrid.Rows[count].Cells[2].Value = mynode.Phone;
                            if (mynode.Parent != null) DataGrid.Rows[count].Cells[4].Value = mynode.Parent.Key;
                            if (mynode.Left != null) DataGrid.Rows[count].Cells[5].Value = mynode.Left.Key;
                            if (mynode.Right != null) DataGrid.Rows[count].Cells[6].Value = mynode.Right.Key;
                            Find(mynode.Left);
                            Find(mynode.Right);
                        }
                    }
                }
                Find(tree);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
