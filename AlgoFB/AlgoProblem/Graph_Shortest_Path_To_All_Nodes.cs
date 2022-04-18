using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class  Algo
    {
        public static List<int> Graph_Shortest_Path_To_All_Nodes(int rootData, 
            Dictionary<int, GraphNode> allNodes)
        {
            List<int> distances = new List<int>();
            /////////////////////////////////////////////////////////////
            
            /*Dictionary<int, int> visitedNodes = new Dictionary<int, int>();
            //       data/val vs distance

            //Add distance as 0 to rootData to rootData
            visitedNodes.Add(rootData, 0);
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(rootData);

            while (qu.Count != 0)
            {
                var current_node_data = qu.Dequeue();
                var node = allNodes[current_node_data];
                foreach (var child in node.Childs_or_Adjacents)
                {
                    if (!visitedNodes.ContainsKey(child.Data))
                    {
                        qu.Enqueue(child.Data);
                        visitedNodes.Add(child.Data, visitedNodes[current_node_data] + 1);
                    }
                    else if (visitedNodes[child.Data] > visitedNodes[current_node_data] + 1)
                    { 
                        visitedNodes.Add(child.Data, visitedNodes[child.Data] + 1);

                    }
                }
            }*/

            /////////////////////////////////////////////////////////////
            return distances;
        }

        
    }
}
