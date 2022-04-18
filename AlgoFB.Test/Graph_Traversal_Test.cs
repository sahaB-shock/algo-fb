using AlgoFB.DataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class Graph_Traversal_Test
    {
        [TestMethod]
        public void Test_Depth_First_Traversal()
        {
            Graph_Depth_n_Breadth_First_Search dfs = new Graph_Depth_n_Breadth_First_Search();
            dfs.Add_Adjuscents_Or_Add_Edge(1, 2);
            dfs.Add_Adjuscents_Or_Add_Edge(1, 3);
            dfs.Add_Adjuscents_Or_Add_Edge(1, 5);
            dfs.Add_Adjuscents_Or_Add_Edge(5, 6);
            dfs.Add_Adjuscents_Or_Add_Edge(6, 7);
            dfs.Add_Adjuscents_Or_Add_Edge(4, 4);
            /*
                1 ─ 2  
               / |                   
              3  5    4 ─ 4*              
                  \                
                   6               
                    \              
                     7              
                                   
                                   
            */

            var hasPath = dfs.Has_Path_Depth_First(1, 6);
            hasPath = dfs.Has_Path_Breadth_First(1, 6);
            hasPath = dfs.Has_Path_Breadth_First(2, 6);

        }

        [TestMethod]
        public void Test_Hacker_Rank_Breadth_First_Search_Shortest_Reach()
        {
            Graph_Depth_n_Breadth_First_Search bfs2 = new Graph_Depth_n_Breadth_First_Search();
            bfs2.AddNode(1);
            bfs2.AddNode(2);
            bfs2.AddNode(3);
            bfs2.Add_Adjuscents_Or_Add_Edge(2, 3);
            Console.WriteLine(bfs2.Get_Path_Count_BFS(2, 1));
            Console.WriteLine(bfs2.Get_Path_Count_BFS(2, 3));
        }
        [TestMethod]
        public void Test_Hacker_Rank_Breadth_First_Search_Shortest_Reach_2()
        {
            Graph_Depth_n_Breadth_First_Search bfs2 = new Graph_Depth_n_Breadth_First_Search();
            bfs2.AddNode(1);
            bfs2.AddNode(2);
            bfs2.AddNode(3);
            bfs2.AddNode(4);
            bfs2.AddNode(5);
            bfs2.Add_Adjuscents_Or_Add_Edge(1, 3);
            bfs2.Add_Adjuscents_Or_Add_Edge(1, 2);
            bfs2.Add_Adjuscents_Or_Add_Edge(3, 4);
            var dis = bfs2.Get_Path_Count_BFS_v2(2);
        }

        [TestMethod]
        public void Test_Hacker_Rank_Breadth_First_Search_Shortest_Reach_3_FB_Approach()
        {
            Graph_Depth_n_Breadth_First_Search bfs2 = new Graph_Depth_n_Breadth_First_Search();
            bfs2.AddNode(1);
            bfs2.AddNode(2);
            bfs2.AddNode(3);
            bfs2.AddNode(4);
            bfs2.AddNode(5);
            bfs2.Add_Adjuscents_Or_Add_Edge(1, 3);
            bfs2.Add_Adjuscents_Or_Add_Edge(1, 2);
            bfs2.Add_Adjuscents_Or_Add_Edge(3, 4);
            var dis = AlgoFB.AlgoProblem.Algo.Graph_Shortest_Path_To_All_Nodes(2, bfs2.GetAllNodes());
        }
    }
}
