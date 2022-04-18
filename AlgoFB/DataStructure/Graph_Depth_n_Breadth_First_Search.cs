using AlgoFB.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgoFB.DataStructure
{
    public class Graph_Depth_n_Breadth_First_Search
    {
        Dictionary<int, GraphNode> nodeLookup = new Dictionary<int, GraphNode>();
        public GraphNode GetNode_From_Dictionary_Lookup(int data)
        {
            if (nodeLookup.ContainsKey(data))
            {
                return nodeLookup[data];
            }
            else
            {
                var node = new GraphNode(data);
                nodeLookup.Add(data, node);
                return node;
            }
        }

        public void Add_Adjuscents_Or_Add_Edge(int source, int destination)
        {
            var s = GetNode_From_Dictionary_Lookup(source);
            var d = GetNode_From_Dictionary_Lookup(destination);
            s.Childs_or_Adjacents.Add(d);
        }

        public bool Has_Path_Depth_First(int source, int destination)
        {
            var s = GetNode_From_Dictionary_Lookup(source);
            var d = GetNode_From_Dictionary_Lookup(destination);
            HashSet<int> hs_nodes_visited = new HashSet<int>();
            return Has_Path_Depth_First(s, d, hs_nodes_visited);

        }

        private bool Has_Path_Depth_First(GraphNode source, GraphNode destination, HashSet<int> hs_nodes_visited)
        {
            //if hashset has the source (visited) value, that means there is no path
            if (hs_nodes_visited.Contains(source.Data))
                return false;

            //Add this source is visisted
            hs_nodes_visited.Add(source.Data);

            //If source and destination is same, we found the path
            if (source == destination)
            {
                return true;
            }
            foreach (var child_of_source in source.Childs_or_Adjacents)
            {
                var path_found = Has_Path_Depth_First(child_of_source, destination, hs_nodes_visited);
                if (path_found)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddNode(int data)
        {
            var node = new GraphNode(data);
            nodeLookup.Add(data, node);
        }

        /*
            1 ─ 2  
           / |                   
          3  5    4 ─ 4*              
              \                
               6               
                \              
                 7              


        */

        public bool Has_Path_Breadth_First(int source, int destination)
        {
            var source_node = GetNode_From_Dictionary_Lookup(source);
            var destination_node = GetNode_From_Dictionary_Lookup(destination);
            return Has_Path_Breadth_First(source_node, destination_node);

        }

        private bool Has_Path_Breadth_First(GraphNode source_node, GraphNode destination_node)
        {
            HashSet<int> hs_nodes_visited = new HashSet<int>();
            Queue<GraphNode> qu = new Queue<GraphNode>();

            qu.Enqueue(source_node);

            while (qu.Count != 0)
            {
                var node = qu.Dequeue();
                hs_nodes_visited.Add(node.Data);
                //If dequed item matches with destination return true as path found.
                if (node == destination_node)
                    return true;


                foreach (var childNode in node.Childs_or_Adjacents)
                {
                    //If not visted add in queue
                    if (!hs_nodes_visited.Contains(childNode.Data))
                    {
                        qu.Enqueue(childNode);
                    }
                }
            }
            return false;
        }
        public Dictionary<int, GraphNode> GetAllNodes()
        {
            return nodeLookup;
        }
        //Ref: https://www.youtube.com/watch?v=0XgVhsMOcQM
        public List<int> Get_Path_Count_BFS_v2(int rootData)
        {
            List<int> shortest_reaches = new List<int>();
            var nodesDics = GetAllNodes();
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(rootData);

            int[] distances = new int[nodesDics.Count + 1];
            for (int i = 1; i < distances.Length; i++)
            {
                distances[i] = -1; //Set all nodes' path to -1.
            }
            distances[(int)rootData] = 0;//set start's distance to 0.
            while (qu.Count != 0)
            {
                var nodeVal = qu.Dequeue();
                foreach (var child in nodesDics[nodeVal].Childs_or_Adjacents)
                {
                    if (distances[(int)child.Data] == -1)
                    {
                        distances[child.Data] = distances[nodeVal] + 6;
                        qu.Enqueue(child.Data);
                    }
                }
            }
            shortest_reaches = distances.ToList().Where(x => x != 0).ToList();
            return shortest_reaches;
        }
        public int Get_Path_Count_BFS(int rootData, int destinationData)//TODO
        {
            GraphNode root_node = GetNode_From_Dictionary_Lookup(rootData);
            GraphNode dest_Node = GetNode_From_Dictionary_Lookup(destinationData);


            //HashSet<int> hs_nodes_visited = new HashSet<int>();//wow
            Queue<GraphNode> qu = new Queue<GraphNode>();

            int[] distances = new int[nodeLookup.Count + 1];//WOW
            Array.Fill(distances, -1);
            distances[(int)rootData] = 0;
            qu.Enqueue(root_node);

            while (qu.Count != 0)
            {
                GraphNode cur = qu.Dequeue();
                foreach (var child in cur.Childs_or_Adjacents)
                {
                    if (distances[(int)child.Data] == -1)
                    {
                        distances[(int)child.Data] = distances[(int)cur.Data] + 6;
                        if (child.Data == destinationData)
                        {
                            return distances[(int)child.Data];
                        }
                        qu.Enqueue(child);
                    }
                }
            }
            return distances[(int)destinationData];
        }

    }
}
