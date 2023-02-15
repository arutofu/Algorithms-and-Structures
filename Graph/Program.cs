using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            
            StreamReader reader = new StreamReader(GlobalVar.filePath, Encoding.UTF8);
            for (int i = 0; i == 0; i++)
            {
                string words = reader.ReadLine();
                GlobalVar.vertexCount = Convert.ToInt32(words);
            }
            int[,] matr = new int[GlobalVar.vertexCount, GlobalVar.vertexCount + 1];
            for (int i = 0; i < GlobalVar.vertexCount; i++)
            {
                string[] words = reader.ReadLine().Split('/');
                for (int j = 0; j < GlobalVar.vertexCount + 1; j++)
                {
                    if (j == 0)
                    {
                        graph.AddVertex(words[0]);
                    }
                    matr[i, j] = Convert.ToInt32(words[j]);
                }
            }
            reader.Close();
            for (int i = 0; i < GlobalVar.vertexCount; i++)
            {
                for (int j = 0; j < GlobalVar.vertexCount + 1; j++)
                {
                    if (j > 0 && matr[i,j] == 1)
                    {
                        graph.AddEdge(Convert.ToString(matr[i, 0]), Convert.ToString(j));
                    }
                }
            }  // Считывание из файла
            do
            {
                Console.Clear();
                Console.WriteLine(" 1 Добавить вершину  \n" +
                                  " 2 Добавить ребро    \n" +
                                  " 3 Удалить вершину   \n" +
                                  " 4 Удалить ребро     \n" +
                                  " 5 Вывести           \n" +
                                  " 6 Выход"               );

                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.WriteLine('\n');
                        Console.WriteLine("Назовите вершину");
                        graph.AddVertex(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine('\n');
                        Console.WriteLine("Введите связь, от какой вершины до какой");
                        graph.AddEdge(Console.ReadLine(), Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine('\n');
                        Console.WriteLine("Введите вершину");
                        break;

                    case 4:
                        Console.WriteLine('\n');
                        Console.WriteLine("Введите две вершины");
                        graph.DeleteEdge(Console.ReadLine(), Console.ReadLine());
                        break;

                    case 5:
                        Console.WriteLine('\n');
                        Console.Write(graph.Vertices);
                        Console.ReadKey();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine('\n');
                        Console.WriteLine("Ошибка");
                        break;
                }
            } while (true);
        }
    }
}
