using DataClass;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeFormL;

namespace DataClass
{

    public class FilePath //---------------------------------- ПУТЬ ФАЙЛА ----
    {
        public static string filepath;
    }


    public class SkladData //--------------------------------- ДАННЫЕ ФАЙЛА ----
    {
        public string Tovar;
        public string Phone;
        public int Kategoria;
    }


    public class TreeRoot //---------------------------------- ДЕРЕВО ----
    {
        public string Tovar;
        public string Phone;
        public int Key;

        public TreeRoot Left;
        public TreeRoot Right;
        public TreeRoot Parent;


        public class InsertNode
        {
            public string Tovar;
            public string Phone;
            public int Key;

        }


        public void Insert(string tovar, string phone, int value)
        {
            if (Key == 0)
            {
                Key = value;
                Tovar = tovar;
                Phone = phone;
            }


            else
            {
                if (Key.CompareTo(value) == 1)
                {
                    if (Left == null)
                    {
                        Left = new TreeRoot();
                        Left.Parent = this;
                    }


                    Left.Insert(tovar, phone, value);
                }
                else if (Key.CompareTo(value) == -1)
                {
                    if (Right == null)
                    {
                        Right = new TreeRoot();
                        Right.Parent = this;
                    }


                    Right.Insert(tovar, phone, value);
                }
                else
                    throw new Exception("Узел уже существует");
            }
        }



    }
}


