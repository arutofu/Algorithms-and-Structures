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
using DataClass;

namespace TreeFormL
{
    public partial class AddInfo : Form
    {
        SkladData mydata = new SkladData();

        public AddInfo()
        {
            InitializeComponent();

            TovarBox.Text = "Введите название товара";
            TovarBox.ForeColor = Color.Gray;
            PhoneBox.Text = "Введите номер телефона";
            PhoneBox.ForeColor = Color.Gray;
            KategoriaBox.Text = "Введите категорию товара";
            KategoriaBox.ForeColor = Color.Gray;
        }


        private void ObiemBox_Enter(object sender, EventArgs e)
        {
            if (TovarBox.Text == "Введите название товара")
            {
                TovarBox.Text = "";
                TovarBox.ForeColor = Color.Black;
            }
        }

        private void ObiemBox_Leave(object sender, EventArgs e)
        {
            if (TovarBox.Text == "")
            {
                TovarBox.Text = "Введите название товара";
                TovarBox.ForeColor = Color.Gray;
            }
        }

        private void TovarBox_Enter(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "Введите номер телефона")
            {
                PhoneBox.Text = "";
                PhoneBox.ForeColor = Color.Black;
            }
        }

        private void TovarBox_Leave(object sender, EventArgs e)
        {
            if (PhoneBox.Text == "")
            {
                PhoneBox.Text = "Введите номер телефона";
                PhoneBox.ForeColor = Color.Gray;
            }
        }

        private void PostBox_Enter(object sender, EventArgs e)
        {
            if (KategoriaBox.Text == "Введите категорию товара")
            {
                KategoriaBox.Text = "";
                KategoriaBox.ForeColor = Color.Black;
            }
        }

        private void PostBox_Leave(object sender, EventArgs e)
        {
            if (KategoriaBox.Text == "")
            {
                KategoriaBox.Text = "Введите категорию товара";
                KategoriaBox.ForeColor = Color.Gray;
            }
        }



        private void BackButton_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void OkButton2_Click(object sender, EventArgs e)
        {

            SkladData mydata = new SkladData();


            // GET TOVAR
            if (TovarBox.Text != "")
            {
                try
                {
                    mydata.Tovar = TovarBox.Text;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // GET PHONE 
            if (TovarBox.Text != "")
            {
                if (PhoneBox.Text == "Введите номер телефона")
                    goto firstmark;
                else
                {
                    try
                    {
                        mydata.Phone = Convert.ToString(PhoneBox.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        firstmark:

            // GET KATEGORIA 
            if (KategoriaBox.Text != "")
            {
                if (KategoriaBox.Text == "Введите категорию товара")
                    goto twomark;
                else
                {
                    try
                    {
                        mydata.Kategoria = Convert.ToInt16(KategoriaBox.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        twomark:


            if (TovarBox.Text == "Введите название товара")
            {
                MessageBox.Show("Вы не ввели название товара!");
                if (PhoneBox.Text == "Введите номер телефона")
                {
                    MessageBox.Show("Вы не ввели номер телефона!");
                    if (KategoriaBox.Text == "Введите категорию товара")
                    {
                        MessageBox.Show("Вы не ввели категорию товара!");
                    }
                }
            }


            try
            {
                int iter = 0;

                try
                {
                    using (StreamReader newline = new StreamReader(FilePath.filepath, Encoding.UTF8))
                    {
                        String line;
                        while ((line = newline.ReadLine()) != null)
                        {
                            iter++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                FileStream file = new FileStream(FilePath.filepath, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file, Encoding.UTF8);


                void InsertData(SkladData newdata)
                {
                    if (TovarBox.Text == "Введите название товара")
                    {
                        MessageBox.Show("Вы не ввели название товара!");
                        if (PhoneBox.Text == "Введите номер телефона")
                        {
                            MessageBox.Show("Вы не ввели номер телефона!");
                            if (KategoriaBox.Text == "Введите категорию товара")
                            {
                                MessageBox.Show("Вы не ввели категорию товара!");
                            }
                        }
                    }
                    else
                    {
                        writer.Write(newdata.Tovar);
                        writer.Write('/');
                        writer.Write(newdata.Phone);
                        writer.Write('/');
                        writer.Write(newdata.Kategoria);

                        writer.Close();         // Не закрыв поток, в файл ничего не запишется

                        MessageBox.Show("Успешно добавлено в файл");
                        TovarBox.Text = "Введите название товара";
                        TovarBox.ForeColor = Color.Gray;
                        PhoneBox.Text = "Введите номер телефона";
                        PhoneBox.ForeColor = Color.Gray;
                        KategoriaBox.Text = "Введите категорию товара";
                        KategoriaBox.ForeColor = Color.Gray;
                    }
                }

                void InsertData2(SkladData newdata)
                {
                    if (TovarBox.Text == "Введите название товара")
                    {
                        MessageBox.Show("Вы не ввели название товара!");
                        if (PhoneBox.Text == "Введите номер телефона")
                        {
                            MessageBox.Show("Вы не ввели номер телефона!");
                            if (KategoriaBox.Text == "Введите категорию товара")
                            {
                                MessageBox.Show("Вы не ввели категорию товара!");
                            }
                        }
                    }
                    else
                    {
                        writer.Write('\n');
                        writer.Write(newdata.Tovar);
                        writer.Write('/');
                        writer.Write(newdata.Phone);
                        writer.Write('/');
                        writer.Write(newdata.Kategoria);


                        writer.Close();         // Не закрыв поток, в файл ничего не запишется

                        MessageBox.Show("Успешно добавлено в файл");
                        TovarBox.Text = "Введите название товара";
                        TovarBox.ForeColor = Color.Gray;
                        PhoneBox.Text = "Введите номер телефона";
                        PhoneBox.ForeColor = Color.Gray;
                        KategoriaBox.Text = "Введите категорию товара";
                        KategoriaBox.ForeColor = Color.Gray;
                    }
                }


                if (iter == 0)
                {
                    InsertData(mydata);
                }
                else InsertData2(mydata);


                writer.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }
    }
}

