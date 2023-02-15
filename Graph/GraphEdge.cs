using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class GraphEdge
    {
        // Связанная вершина
        public GraphVertex ConnectedVertex { get; }

        // Вес ребра
        // public int EdgeWeight { get; }

        // Конструктор
        /// <param name="connectedVertex">Связанная вершина</param>
        public GraphEdge(GraphVertex connectedVertex)
        {
            ConnectedVertex = connectedVertex;
        }
    }
}
