using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class GraphVertex
    {
        // Название вершины
        public string Name { get; }

        // Список ребер
        public List<GraphEdge> Edges { get; }

        // Конструктор
        /// <param name="vertexName">Название вершины</param>
        public GraphVertex(string vertexName)
        {
            Name = vertexName;
            Edges = new List<GraphEdge>();
        }

        // Добавить ребро
        /// <param name="newEdge">Ребро</param>
        public void AddEdge(GraphEdge newEdge)
        {
            Edges.Add(newEdge);
        }

        // Добавить ребро
        /// <param name="vertex">Вершина</param>
        public void AddEdge(GraphVertex vertex)
        {
            AddEdge(new GraphEdge(vertex));
        }

        public void DelEdge(GraphEdge edge)
        {
            Edges.Remove(edge);
        }

        public void DeleteEdge(GraphVertex vert)
        {
            DelEdge(new GraphEdge(vert));
        }
    }
}
