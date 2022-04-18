using System.Collections.Generic;

namespace AlgoFB.Models
{
    public class GraphNode
    {
        public int Data;
        public List<GraphNode> Childs_or_Adjacents;

        public GraphNode(int data)
        {
            Data = data;
            Childs_or_Adjacents = new List<GraphNode>();
        }
    }
}