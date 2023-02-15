using dataTree;
using StructsCompare1;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public TreeData.TreeRoot tree = new TreeData.TreeRoot();
        public HashData[] hash = new HashData[GlobalVariables.hashSize];

        public void FindGrid(int searchData)
        {
            int gridCount1 = 0;
            int gridCount2 = 0;

            while (gridCount1 < GlobalVariables.treeElemSize)
            {
                if ((int)GridTovar.Rows[gridCount1].Cells[2].Value == Convert.ToInt32(searchData))
                {
                    GridTovar.Rows[gridCount1].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(105, 255, 115);
                    GridTovar.Rows[gridCount1].Cells[1].Style.BackColor = System.Drawing.Color.FromArgb(105, 255, 115);
                    GridTovar.Rows[gridCount1].Cells[2].Style.BackColor = System.Drawing.Color.FromArgb(105, 255, 115);
                }
                gridCount1++;
            }

            while (gridCount2 < GlobalVariables.hashElemSize)
            {
                if ((int)GridPost.Rows[gridCount2].Cells[4].Value == Convert.ToInt32(searchData))
                {
                    GridPost.Rows[gridCount2].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(105, 255, 115);
                    GridPost.Rows[gridCount2].Cells[1].Style.BackColor = System.Drawing.Color.FromArgb(105, 255, 115);
                    GridPost.Rows[gridCount2].Cells[2].Style.BackColor = System.Drawing.Color.FromArgb(105, 255, 115);
                    GridPost.Rows[gridCount2].Cells[3].Style.BackColor = System.Drawing.Color.FromArgb(105, 255, 115);
                    GridPost.Rows[gridCount2].Cells[4].Style.BackColor = System.Drawing.Color.FromArgb(105, 255, 115);
                }
                gridCount2++;
            }
        }

        internal void GridColour()
        {
            int gridCount1 = 0;
            int gridCount2 = 0;
            while (gridCount1 < GlobalVariables.treeElemSize)
            {
                if (Convert.ToInt32(GridTovar.Rows[gridCount1].Cells[0].Value) % 2 == 0)
                {
                    GridTovar.Rows[gridCount1].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                    GridTovar.Rows[gridCount1].Cells[1].Style.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                    GridTovar.Rows[gridCount1].Cells[2].Style.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                }
                else
                {
                    GridTovar.Rows[gridCount1].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    GridTovar.Rows[gridCount1].Cells[1].Style.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    GridTovar.Rows[gridCount1].Cells[2].Style.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
                gridCount1++;
            }
            while (gridCount2 < GlobalVariables.hashElemSize)
            {
                if (Convert.ToInt32(GridPost.Rows[gridCount2].Cells[0].Value) % 2 == 0)
                {
                    GridPost.Rows[gridCount2].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                    GridPost.Rows[gridCount2].Cells[1].Style.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                    GridPost.Rows[gridCount2].Cells[2].Style.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                    GridPost.Rows[gridCount2].Cells[3].Style.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                    GridPost.Rows[gridCount2].Cells[4].Style.BackColor = System.Drawing.Color.FromArgb(232, 232, 232);
                }
                else
                {
                    GridPost.Rows[gridCount2].Cells[0].Style.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    GridPost.Rows[gridCount2].Cells[1].Style.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    GridPost.Rows[gridCount2].Cells[2].Style.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    GridPost.Rows[gridCount2].Cells[3].Style.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    GridPost.Rows[gridCount2].Cells[4].Style.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                }
                gridCount2++;
            }
        }

        internal void TreeToForm(ref TreeData.TreeRoot treeData)
        {
            GridTovar.Rows[GlobalVariables.gridCounter].Cells[0].Value = GlobalVariables.gridCounter + 1;
            GridTovar.Rows[GlobalVariables.gridCounter].Cells[1].Value = treeData.Depth;
            GridTovar.Rows[GlobalVariables.gridCounter].Cells[2].Value = treeData.Key;

            GlobalVariables.gridCounter++;

            if (treeData.Left != null)
                TreeToForm(ref treeData.Left);
            if (treeData.Right != null)
                TreeToForm(ref treeData.Right);
        }

        internal void HashToForm(ref HashData[] hashData)
        {
            int counter = 0;
            for (int i = 0; i < GlobalVariables.hashSize; i++)
            {
                if (hashData[i].Empty == false)
                {
                    GridPost.Rows[counter].Cells[0].Value = counter + 1;
                    GridPost.Rows[counter].Cells[1].Value = hashData[i].Index1;
                    GridPost.Rows[counter].Cells[2].Value = hashData[i].Index2;
                    GridPost.Rows[counter].Cells[3].Value = Math.Abs(hashData[i].Index2 - hashData[i].Index1);
                    GridPost.Rows[counter].Cells[4].Value = hashData[i].Key;
                    counter++;
                }
            }
        }

        internal void GridClear(ref DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 0)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }

        internal int Hash1(int Number)
        {
            if (Number > GlobalVariables.hashSize)
            {
                return (Number % GlobalVariables.hashSize);
            }
            else
            {
                return (GlobalVariables.hashSize % Number);
            }
        }

        internal void HashObhod()
        {
            if (hash.Equals(null) == false)
            {
                for (int i = 0; i < hash.Length; i++)
                {
                    if (hash[i].Empty == false)
                    {
                        GlobalVariables.hashElemSize++;
                    }
                }
            }
            else
                MessageBox.Show("Хеша не существует");
        }

        internal bool HashFindNumber(int key)
        {
            int postCount = 0;
            int Place = Hash1(key);
        repeatmark:
            if (hash[Place].Key != key)  // если не совпало
            {
                while (hash[Place].Key != key && postCount < GlobalVariables.hashSize)  // пока не дойдем
                {
                    if (Place == GlobalVariables.hashSize - 1)  // если это последний элемент
                    {
                        Place = 0;      // идем в начало
                        goto repeatmark;
                    }
                    GlobalVariables.SearchHash++;
                    Place++;  // иначе просто перейдем к следующей ячейке
                    postCount++;
                }
                if (hash[Place].Key != key)
                {
                    return false;
                }
            }
            return true;
        }

        internal void TreeFindNumber(ref TreeData.TreeRoot mynode, int key)
        {
            if (mynode.Equals(null) == false)
            {
                if (mynode.Key == key)
                {
                    GlobalVariables.TreeCompare = true;
                }
                else
                {
                    if (mynode.Key.CompareTo(key) == 1)
                    {
                        if (mynode.Left != null)
                        {
                            GlobalVariables.SearchTree++;
                            TreeFindNumber(ref mynode.Left, key);
                        }
                    }
                    if (mynode.Key.CompareTo(key) == -1 || mynode.Key.CompareTo(key) == 0)
                    {
                        if (mynode.Right != null)
                        {
                            GlobalVariables.SearchTree++;
                            TreeFindNumber(ref mynode.Right, key);
                        }
                    }
                }
            }
        }

        internal void HashInsert(ref HashData[] hashData, int Number)
        {
            int Place = Hash1(Number);
            int Index1 = Place;
        repeatmark:
            if (!hashData[Place].Empty)  // если ячейка не пустая
            {
                while (!hashData[Place].Empty && hashData[Place].Key != Number)  // пока не найдем пустую
                {
                    if (Place == GlobalVariables.hashSize - 1)  // если это последний элемент
                    {
                        if (hashData[Place].Empty)      // если он пустой добавляем и выходим
                        {
                            hashData[Place].Key = Number;        
                            hashData[Place].Index1 = Index1;
                            hashData[Place].Index2 = Place;
                            hashData[Place].Empty = false;

                            goto thismark;
                        }
                        else if (!hashData[Place].Empty)  // если он не пустой
                        {
                            Place = 0;  // идем в начало  //   Collision++;

                            goto repeatmark;
                        }
                    }
                    Place++;  // иначе просто перейдем к следующей ячейке   //   Collision++;
                }
                if (hashData[Place].Key == Number)
                {
                    MessageBox.Show("Повторение ключа");
                    goto thismark;
                }
            }
            hashData[Place].Key = Number;
            hashData[Place].Index1 = Index1;
            hashData[Place].Index2 = Place;
            hashData[Place].Empty = false;
        thismark:;
        }

        internal void CompareTree()
        {
            GlobalVariables.AllCompareTree = 0;
            GlobalVariables.AverageCompareTree = 0;

            for (int i = 0; i < GlobalVariables.treeSize; i++)
            {
                GlobalVariables.AllCompareTree += Convert.ToInt32(GridTovar.Rows[i].Cells[1].Value);
            }
            AllCompTree.Text = Convert.ToString(GlobalVariables.AllCompareTree);
            GlobalVariables.AverageCompareTree = GlobalVariables.AllCompareTree / GlobalVariables.treeSize;
            AverageTree.Text = Convert.ToString(GlobalVariables.AverageCompareTree);
        }
        internal void CompareHash()
        {
            GlobalVariables.AllCompareHash = 0;
            GlobalVariables.AverageCompareHash = 0;

            for (int i = 0; i < GlobalVariables.hashElemSize; i++)
            {
                GlobalVariables.AllCompareHash += Convert.ToInt32(GridPost.Rows[i].Cells[3].Value);
            }
            AllCompHash.Text = Convert.ToString(Math.Abs(GlobalVariables.AllCompareHash));
            GlobalVariables.AverageCompareHash = GlobalVariables.AllCompareHash / GlobalVariables.hashSize;
            AverageHash.Text = Convert.ToString(Math.Abs(GlobalVariables.AverageCompareHash));
        }

        internal void HashLoad(ref HashData[] hash)
        {
            HashSizeLabel.Text = "= " + Convert.ToString(GlobalVariables.hashSize);
            for (int iter = 0; iter < GlobalVariables.hashSize; iter++)
            {
                hash[iter] = new HashData
                {
                    Index1 = 0,
                    Index2 = 0,
                    Key = 0,
                    Empty = true,
                };
            }

            using (StreamReader reader = new StreamReader(GlobalVariables.numbFile, Encoding.UTF8))
            {
                for (int i = 0; i < GlobalVariables.hashElemSize; i++)
                {
                    string words = reader.ReadLine();
                    int Number = Convert.ToInt32(words);

                    HashInsert(ref hash, Number);
                }
            }
            GlobalVariables.gridCounter = 0;
            //GlobalVariables.hashSize = 0;
            GridClear(ref GridPost);
            //HashObhod();
            GridPost.Rows.Add(GlobalVariables.hashElemSize);
            HashToForm(ref hash);
            CompareHash();
        }

        internal void TreeLoad(ref TreeData.TreeRoot tree)
        {
            using (StreamReader reader = new StreamReader(GlobalVariables.numbFile, Encoding.UTF8))
            {
                for (int i = 0; i < GlobalVariables.treeElemSize; i++)
                {
                    int Count = i + 1;
                    string words = reader.ReadLine();
                    try
                    {
                        int Depth = 0;
                        tree.Insert(Convert.ToInt32(words), Depth);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                GlobalVariables.gridCounter = 0;
                GlobalVariables.treeElemSize = 0;
                GridClear(ref GridTovar);
                tree.TreeObhod(ref tree);
                GridTovar.Rows.Add(GlobalVariables.treeElemSize);
                TreeToForm(ref tree);
                CompareTree();
            }
        }

        internal void ReSize(ref HashData[] hash)
        {
            hash = new HashData[GlobalVariables.hashSize];
        }

        internal void TreeAdd(ref TreeData.TreeRoot tree, string data)
        {
            try
            {
                int Depth = 0;
                tree.Insert(Convert.ToInt32(data), Depth);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GlobalVariables.gridCounter = 0;
            GlobalVariables.treeElemSize = 0;
            GridClear(ref GridTovar);
            tree.TreeObhod(ref tree);
            GridTovar.Rows.Add(GlobalVariables.treeElemSize);
            TreeToForm(ref tree);
            GridColour();
            CompareTree();
        }

        internal void HashAdd(ref HashData[] hash, string data)
        {
            try
            {
                HashInsert(ref hash, Convert.ToInt32(data));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GlobalVariables.gridCounter = 0;
            GlobalVariables.hashElemSize = 0;
            GridClear(ref GridPost);
            HashObhod();
            GridPost.Rows.Add(GlobalVariables.hashElemSize);
            HashToForm(ref hash);
            GridColour();
            CompareHash();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HashLoad(ref hash);
            TreeLoad(ref tree);
            GridColour();
        }

        private void SearchNumber_Click(object sender, EventArgs e)
        {
            GlobalVariables.SearchHash = 0;
            GlobalVariables.SearchTree = 0;

            GridColour();

            SearchNumber searchNum = new SearchNumber();
            searchNum.Owner = this;
            searchNum.ShowDialog();

            if (searchNum.DialogResult == DialogResult.OK)
            {
                if (searchNum.SearchTovarBox.Text != "")
                {
                    GlobalVariables.TreeCompare = false;
                    bool exception = false;
                    try
                    {
                        FindGrid(Convert.ToInt32(searchNum.SearchTovarBox.Text));
                        TreeFindNumber(ref tree, Convert.ToInt32(searchNum.SearchTovarBox.Text));
                    }
                    catch (Exception ex)
                    {
                        exception = true;
                        MessageBox.Show(ex.Message);
                    }
                    if (exception == false)
                    {
                        if (HashFindNumber(Convert.ToInt32(searchNum.SearchTovarBox.Text)) == true && GlobalVariables.TreeCompare == true)
                        {
                            MessageBox.Show("Найдено");
                            FindGrid(Convert.ToInt32(searchNum.SearchTovarBox.Text));
                            SearchHash.Text = Convert.ToString(GlobalVariables.SearchHash);
                            SearchTree.Text = Convert.ToString(GlobalVariables.SearchTree);
                        }
                        else
                        {
                            if (HashFindNumber(Convert.ToInt32(searchNum.SearchTovarBox.Text)) == false)
                            {
                                MessageBox.Show("Не найдено в хеш-таблице");
                            }
                            if (GlobalVariables.TreeCompare == false)
                            {
                                MessageBox.Show("Не найдено в дереве");
                            }
                        }
                    }
                    else
                    {
                        searchNum.ShowDialog();
                    }
                }
            }
        }

        private void HashSizeButton_Click(object sender, EventArgs e)
        {
            if (HashNewSize.Text != "")
            {
                try
                {
                    if (Convert.ToInt32(HashNewSize.Text) < GlobalVariables.hashElemSize)
                    {
                        MessageBox.Show("Слишком маленький размер");
                    }
                    else
                    {
                        GlobalVariables.hashSize = Convert.ToInt32(HashNewSize.Text);
                        ReSize(ref hash);
                        HashLoad(ref hash);
                        GridColour();
                        HashSizeLabel.Text = "= " + Convert.ToString(GlobalVariables.hashSize);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddInfo addinfo = new AddInfo();
            addinfo.Owner = this;
            addinfo.ShowDialog();

            if (addinfo.DialogResult == DialogResult.OK)
            {
                if (addinfo.AddText.Text != "")
                {
                    try
                    {
                        if (Convert.ToInt32(addinfo.AddText.Text) > 0)
                        {
                            HashAdd(ref hash, addinfo.AddText.Text);
                            TreeAdd(ref tree, addinfo.AddText.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
