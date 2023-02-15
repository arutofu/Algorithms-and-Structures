using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph
    {
        // Список вершин графа
        public List<GraphVertex> Vertices { get; }

        // Конструктор
        public Graph()
        {
            Vertices = new List<GraphVertex>();
        }

        // Добавление вершины
        /// <param name="vertexName">Имя вершины</param>
        public void AddVertex(string vertexName)
        {
            Vertices.Add(new GraphVertex(vertexName));
        }

        // Поиск вершины
        /// <param name="vertexName">Название вершины</param>
        public GraphVertex FindVertex(string vertexName)
        {
            foreach (var v in Vertices)
            {
                if (v.Name.Equals(vertexName))
                {
                    return v;
                }
            }

            return null;
        }

        // Добавление ребра
        /// <param name="firstName">Имя первой вершины</param>
        /// <param name="secondName">Имя второй вершины</param>
        /// <param name="weight">Вес ребра соединяющего вершины</param>
        public void AddEdge(string firstName, string secondName)
        {
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v2 != null && v1 != null)
            {
                v1.AddEdge(v2); // от v1 до v2
            //  v2.AddEdge(v1);
            }
            else
            {
                if (v1 == null)
                {
                    Console.WriteLine("Вершины <{0}> не существует", v1);
                }
                if (v2 == null)
                {
                    Console.WriteLine("Вершины <{0}> не существует", v2);
                }
            }
        }

        public void DeleteEdge(string firstName, string secondName)
        {
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v2 != null && v1 != null)
            {
                v1.DeleteEdge(v2);
            }
            else
            {
                if (v1 == null)
                {
                    Console.WriteLine("Вершины <{0}> не существует", v1);
                }
                if (v2 == null)
                {
                    Console.WriteLine("Вершины <{0}> не существует", v2);
                }
            }
        }
    }
}
