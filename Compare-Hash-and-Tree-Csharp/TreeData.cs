using Main;
using System;
using System.Windows.Forms;

namespace dataTree
{
    public class TreeData
    {
        public class SkladData
        {
            public string masTovar;
            public string masPost;
            public int masObiem;
        }
        public class TreeNew
        {
            public string Tovar;
            public string Post;
            public int Obiem;

            public TreeNew Left;
            public TreeNew Right;
            public TreeNew Parent;
            public TreeNew Root;

            public void InsertNew(string insTovar, string insPost, int insObiem)
            {
                if (this.Parent == null && this.Left == null && this.Right == null && this.Root == null)
                {
                    Obiem = insObiem;
                    Tovar = insTovar;
                    Post = insPost;
                    this.Root = this;
                }
                else
                {
                    if (this.Tovar == null)
                    {
                        Obiem = insObiem;
                        Tovar = insTovar;
                        Post = insPost;
                        this.Root = Parent.Root;
                    }
                    else
                    {
                        if (Tovar.CompareTo(insTovar) == 1)
                        {
                            if (Left == null)
                            {
                                Left = new TreeNew();
                                Left.Parent = this;
                            }
                            Left.InsertNew(insTovar, insPost, insObiem);
                        }
                        else if (Tovar.CompareTo(insTovar) == -1 || Tovar.CompareTo(insTovar) == 0)
                        {
                            if (Right == null)
                            {
                                Right = new TreeNew();
                                Right.Parent = this;
                            }
                            Right.InsertNew(insTovar, insPost, insObiem);
                        }
                        else
                            throw new Exception("Узел уже существует");
                    }
                }
            }

            public void InsertPostNew(string insTovar, string insPost, int insObiem)
            {
                if (Post == null)
                {
                    Post = insPost;
                    Obiem = insObiem;
                    Tovar = insTovar;
                }
                else
                {
                    if (Tovar.CompareTo(insPost) == 1)
                    {
                        if (Left == null)
                        {
                            Left = new TreeNew();
                            Left.Parent = this;
                        }
                        Left.InsertPostNew(insTovar, insPost, insObiem);
                    }
                    else if (Tovar.CompareTo(insPost) == -1 || Tovar.CompareTo(insPost) == 0)
                    {
                        if (Right == null)
                        {
                            Right = new TreeNew();
                            Right.Parent = this;
                        }
                        Right.InsertPostNew(insTovar, insPost, insObiem);
                    }
                    else
                        throw new Exception("Узел уже существует");
                }
            }

            public void TreeObhodNew(ref TreeData.TreeNew treeRoot)
            {
                GlobalVariables.treeSize++;
                if (treeRoot.Left != null)
                    TreeObhodNew(ref treeRoot.Left);
                if (treeRoot.Right != null)
                    TreeObhodNew(ref treeRoot.Right);
            }
        }

        public class TreeRoot //------------ ДЕРЕВО -----------
        {
            public int Key;
            public int Depth;

            public TreeRoot Left;
            public TreeRoot Right;
            public TreeRoot Parent;
            public TreeRoot Root;

            public void Insert(int InsKey, int insDepth)
            {
                if (this.Parent == null && this.Left == null && this.Right == null && this.Root == null)
                {
                    Key = InsKey;
                    Depth = insDepth;
                    this.Root = this;
                }
                else
                {
                    if (this.Key == 0)
                    {
                        Key = InsKey;
                        Depth = insDepth;
                        this.Root = Parent.Root;
                    }
                    else
                    {
                        if (Key.CompareTo(InsKey) == 1)
                        {
                            if (Left == null)
                            {
                                Left = new TreeRoot();
                                Left.Parent = this;
                            }
                            insDepth++;
                            Left.Insert(InsKey, insDepth);
                        }
                        else if (Key.CompareTo(InsKey) == -1 || Key.CompareTo(InsKey) == 0)
                        {
                            if (Right == null)
                            {
                                Right = new TreeRoot();
                                Right.Parent = this;
                            }
                            insDepth++;
                            Right.Insert(InsKey, insDepth);
                        }
                        else
                            throw new Exception("Узел уже существует");
                    }
                }
            }

            public void TreeObhod(ref TreeRoot treeRoot)
            {

                GlobalVariables.treeElemSize++;

                if (treeRoot.Left != null)
                    TreeObhod(ref treeRoot.Left);
                if (treeRoot.Right != null)
                    TreeObhod(ref treeRoot.Right);
            }
        }
    }
}
