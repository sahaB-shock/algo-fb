using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgoFB.DataStructure
{
    public class Binary_Search_Tree
    {
        private TreeNode _root;

        public Binary_Search_Tree()
        {
            _root = null;
        }

        #region Insert

        public TreeNode Insert(int data)
        {
            _root = insertNode(_root, data);
            return _root;
        }

        private TreeNode insertNode(TreeNode root, int data)
        {
            if (root == null)
            {
                root = new TreeNode(data);
                return root;
            }

            if (data < root.Data)
            {
                root.Left = insertNode(root.Left, data);
            }
            else
            {
                root.Right = insertNode(root.Right, data);
            }
            return root;
        }

        #endregion Insert

        public static bool Contains(int data, TreeNode root)
        {
            if (root == null)
                return false;
            if (root.Data == data)
                return true;
            var inleft = Contains(data, root.Left);

            if (!inleft)
                inleft = Contains(data, root.Right);
            return inleft;
        }

        public static bool Contains_In_Binary_Search_Tree(int data, TreeNode root)
        {
            if (root == null)
                return false;
            if (root.Data == data)
                return true;

            if (root.Data > data)
                return Contains_In_Binary_Search_Tree(data, root.Left);
            else //root.Data < data
                return Contains_In_Binary_Search_Tree(data, root.Right);
        }

        /*//WOW
         *** Traversal ***
         * Depth First [Recursion]
                Pre Order  - self(root) - Left - Right
                In Order   - Left - self(root) - Right
                Post Order - Left - Right self(root)
         * Breadth First [Queue]
                Level Order 
         * Vertical Order [horizontal distance -1(left) +1(right) Recursion]
         * 
        */

        #region Vertical Traversal
        public static void Get_Vertical_Distance(TreeNode node, int horz_Distance, SortedDictionary<int, List<int>> verti_nodes)
        {
            if (node == null)
                return;

            if (verti_nodes.ContainsKey(horz_Distance))
            {
                //Append
                verti_nodes[horz_Distance].Add(node.Data);
            }
            else
            {
                //construct
                verti_nodes.Add(horz_Distance, new List<int>() { node.Data });
            }
            Get_Vertical_Distance(node.Left, horz_Distance - 1, verti_nodes);
            Get_Vertical_Distance(node.Right, horz_Distance + 1, verti_nodes);
        }

        //https://www.geeksforgeeks.org/print-binary-tree-vertical-order/
        #region Left Min | Right Max Distance

        /// <summary>
        /// Left -1, -2 etc Right +1 +2 etc Gets the mini left maximum right horizontal distance tree.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="left_right_min_max">The left right minimum maximum.</param>
        /// <param name="hzDis">The hz dis.</param>
        public static void Get_Mini_Left_Max_Right_Horizontal_Distance_Tree(TreeNode node, Horizontal_Left_Right_Dis left_right_min_max, int hzDis)
        {
            if (node == null)
            {
                return;
            }

            //WOW: hzDis will be negative & less than 0
            if (left_right_min_max.Left_Min > hzDis)
            {
                left_right_min_max.Left_Min = hzDis;
            }
            //WOW: hzDis will be positive & greater than 0
            else if (left_right_min_max.Right_Max < hzDis)
            {
                left_right_min_max.Right_Max = hzDis;
            }

            Get_Mini_Left_Max_Right_Horizontal_Distance_Tree(node.Left, left_right_min_max, hzDis - 1);

            Get_Mini_Left_Max_Right_Horizontal_Distance_Tree(node.Right, left_right_min_max, hzDis + 1);
        }

        #endregion Left Min | Right Max Distance 
        #endregion




        #region Print Pre Order | In Order | Post Order [Depth First Traversal]
        public static void Pre_Order_Traversal_Print(TreeNode root)
        {
            if (root == null)
                return;
            //Self
            Console.Write($"{root.Data} ");

            //Left
            Pre_Order_Traversal_Print(root.Left);

            //Right
            Pre_Order_Traversal_Print(root.Right);
        }

        public static void In_Order_Traversal_Print(TreeNode root)
        {
            if (root == null)
                return;
            //Left
            In_Order_Traversal_Print(root.Left);

            //Self
            Console.Write($"{root.Data} ");

            //Right
            In_Order_Traversal_Print(root.Right);
        }

        public static void Post_Order_Traversal_Print(TreeNode root)
        {
            if (root == null)
                return;
            //Left
            Post_Order_Traversal_Print(root.Left);

            //Right
            Post_Order_Traversal_Print(root.Right);

            //Self
            Console.Write($"{root.Data} ");
        }

        #endregion Print Pre Order | In Order | Post Order [Depth First Traversal]

        #region Level Order [Breadth First Traversal]

        public static void Level_Breadth_Order_Traversal_Print(TreeNode root)
        {
            //Level by Level Printing of Binary Tree
            //*//https://www.youtube.com/watch?v=7uG0gLDbhsI
            //https://www.youtube.com/watch?v=86g8jAQug04

            if (root == null)
                return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var currentNode = queue.Dequeue();//WOW

                if (currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);//WOW

                if (currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);//WOW

                Console.Write($"{currentNode.Data} ");
            }

            Console.WriteLine();
        }

        public static void Level_Breadth_Order_Traversal_Print_New_Line(TreeNode root)
        {
            if (root == null)
                return;

            Queue<TreeNode> qu_1 = new Queue<TreeNode>();
            qu_1.Enqueue(root);

            while (qu_1.Count > 0)
            {
                int nodes_count_at_each_level = qu_1.Count;

                while (nodes_count_at_each_level > 0)
                {
                    var tmp = qu_1.Dequeue();
                    Console.Write($"{tmp.Data} ");
                    if (tmp.Left != null)
                    {
                        qu_1.Enqueue(tmp.Left);
                    }
                    if (tmp.Right != null)
                    {
                        qu_1.Enqueue(tmp.Right);
                    }
                    nodes_count_at_each_level--;
                }
                Console.WriteLine();
            }
        }

        #endregion Level Order [Breadth First Traversal]

        #region Average of each Level Breadth First Traversal

        /// <summary>
        /// Averages the of level non recursive.
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        public static IList<double> Average_of_Level_Non_Recursive(TreeNode root)
        {
            List<double> lstAvg = new List<double>();
            if (root == null)
                return lstAvg;

            Queue<TreeNode> qu = new Queue<TreeNode>();
            qu.Enqueue(root);

            while (qu.Count != 0)
            {
                var nodesCount = qu.Count;
                var nodeCountToAvg = qu.Count;
                double sumOfLevel = 0;
                while (nodesCount > 0)
                {
                    var tmpNode = qu.Dequeue();
                    sumOfLevel += tmpNode.Data;

                    if (tmpNode.Left != null)
                        qu.Enqueue(tmpNode.Left);

                    if (tmpNode.Right != null)
                        qu.Enqueue(tmpNode.Right);

                    nodesCount--;
                }

                lstAvg.Add(sumOfLevel / nodeCountToAvg);
            }
            return lstAvg;
        }

        public static IList<double> Average_of_Level_Recursive(TreeNode root)
        {
            if (root == null)
                return null;
            Dictionary<int, List<double>> dic_lvl_vs_lstData = new Dictionary<int, List<double>>();
            helper_Avg_Brute_Force(root, 1, dic_lvl_vs_lstData);

            Dictionary<int, double> dic_lvl = new Dictionary<int, double>();
            helper_Avg_Optimized(root, 1, dic_lvl);
            List<double> avgSum = new List<double>();
            foreach (var item in dic_lvl_vs_lstData)
            {
                avgSum.Add((item.Value.Aggregate((x, y) => x + y) / item.Value.Count));//Replace#1
            }
            return avgSum;
        }

        private static void helper_Avg_Brute_Force(TreeNode node, int level, Dictionary<int, List<double>> dic_lvl_vs_lstData)
        {
            if (node == null)
                return;

            if (dic_lvl_vs_lstData.ContainsKey(level))
            {
                //Update List of that level
                (dic_lvl_vs_lstData[level]).Add(node.Data);
            }
            else
            {
                //Add first data for new level
                dic_lvl_vs_lstData.Add(level, new List<double>() { node.Data });
            }

            if (node.Left != null)
                helper_Avg_Brute_Force(node.Left, level + 1, dic_lvl_vs_lstData);

            if (node.Right != null)
                helper_Avg_Brute_Force(node.Right, level + 1, dic_lvl_vs_lstData);
        }

        private static int count = 0;

        private static void helper_Avg_Optimized(TreeNode node, int level, Dictionary<int, double> dic_lvl_vs_lstData)
        {
            if (node == null)
                return;

            if (dic_lvl_vs_lstData.ContainsKey(level))
            {
                count++;
                double tmp = dic_lvl_vs_lstData[level];
                double newVal = ((tmp * (count - 1)) + node.Data) / count;
                //Update List of that level
                dic_lvl_vs_lstData[level] = newVal;
            }
            else
            {
                //Add first data for new level
                dic_lvl_vs_lstData.Add(level, node.Data);
                count = 1;
            }

            if (node.Left != null)
                helper_Avg_Optimized(node.Left, level + 1, dic_lvl_vs_lstData);

            if (node.Right != null)
                helper_Avg_Optimized(node.Right, level + 1, dic_lvl_vs_lstData);
        }

        #endregion Average of each Level Breadth First Traversal

        #region Bottom up Level Order

        public IList<IList<int>> Level_Order_Bottom_Using_Queue_Stack(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;

            Queue<TreeNode> qu = new Queue<TreeNode>();
            qu.Enqueue(root);
            Stack<List<int>> st = new Stack<List<int>>();
            while (qu.Count != 0)
            {
                var nodeCount = qu.Count;
                List<int> level_items = new List<int>();
                while (nodeCount > 0)
                {
                    var tmpNode = qu.Dequeue();
                    level_items.Add(tmpNode.Data);
                    if (tmpNode.Left != null)
                        qu.Enqueue(tmpNode.Left);
                    if (tmpNode.Right != null)
                        qu.Enqueue(tmpNode.Right);

                    nodeCount--;
                }
                st.Push(level_items);
            }

            while (st.Count != 0)
            {
                result.Add((IList<int>)st.Pop());
            }

            return result;
        }

        #endregion Bottom up Level Order

        #region Depth

        /// <summary>
        /// Maximums the depth. Consider Nodes count to furthermost nodes
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        internal static int MaxDepth(TreeNode root)
        {
            return getMaxDepth(root);
        }

        private static int getMaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            else
            {
                var left_height = getMaxDepth(root.Left);
                var right_height = getMaxDepth(root.Right);
                Console.WriteLine($"left_height {left_height} right_height {right_height} Max {Math.Max(left_height, right_height) + 1}");
                return Math.Max(left_height, right_height) + 1;
            }
        }

        #endregion Depth

        #region Height
        /// <summary>
        /// Maximums the height - Consider only Edgaes
        /// </summary>
        /// <param name="root">The root.</param>
        /// <returns></returns>
        internal static int MaxHeight(TreeNode root)
        {
            return getRootHeight(root);
        }

        private static int getRootHeight(TreeNode root)
        {
            #region Explanation

            /*
             *  1.	bst.Insert(10);
                2.	bst.Insert(20);
                3.	bst.Insert(9);
                4.	bst.Insert(5);
                5.	bst.Insert(6);
                6.	bst.Insert(19);
                7.	bst.Insert(39);
                8.	bst.Insert(29);
                9.	bst.Insert(89);
                10.	bst.Insert(31);
                11.	bst.Insert(42);
                12.	bst.Insert(65);
                13.	bst.Insert(8);

                1.	left_height -1 right_height -1 Max 0
                2.	left_height -1 right_height 0 Max 1
                3.	left_height -1 right_height 1 Max 2
                4.	left_height 2 right_height -1 Max 3
                5.	left_height -1 right_height -1 Max 0
                6.	left_height -1 right_height -1 Max 0
                7.	left_height -1 right_height 0 Max 1
                8.	left_height -1 right_height -1 Max 0
                9.	left_height -1 right_height 0 Max 1
                10.	left_height 1 right_height -1 Max 2
                11.	left_height 1 right_height 2 Max 3
                12.	left_height 0 right_height 3 Max 4
                13.	left_height 3 right_height 4 Max 5

            */

            #endregion Explanation

            if (root == null)
                return -1;
            else
            {
                var left_height = getRootHeight(root.Left);
                var right_height = getRootHeight(root.Right);
                //Console.WriteLine($"left_height {left_height} right_height {right_height} Max {Math.Max(left_height, right_height) + 1}");
                return Math.Max(left_height, right_height) + 1;
            }
        }

        #endregion Height

        #region Nodes Count

        public static int Nodes_Count_Recursive(TreeNode root)
        {
            var nodesCount = 0;
            if (root != null)
                nodesCount = getTotalNodeCount(root);
            return nodesCount;
        }

        private static int getTotalNodeCount(TreeNode root)
        {
            int count = 1;

            if (root.Left != null)
            {
                count = count + getTotalNodeCount(root.Left);
            }
            if (root.Right != null)
            {
                count = count + getTotalNodeCount(root.Right);
            }

            return count;
        }

        public static int Nodes_Count_Breadth_First_Traversal(TreeNode root)
        {
            int nodes_count = 0;
            if (root != null)
            {
                Queue<TreeNode> qu = new Queue<TreeNode>();
                qu.Enqueue(root);
                nodes_count++;

                while (qu.Count != 0)
                {
                    var tmpNode = qu.Dequeue();
                    if (tmpNode.Left != null)
                    {
                        qu.Enqueue(tmpNode.Left);
                        nodes_count++;//We found one more node ++
                    }
                    if (tmpNode.Right != null)
                    {
                        qu.Enqueue(tmpNode.Right);
                        nodes_count++;//We found one more node ++
                    }
                }
            }

            return nodes_count;
        }

        #endregion Nodes Count

        #region Commented Code

        ///// <summary>
        ///// Averages of Levels in Binary Tree
        ///// </summary>
        ///// <param name="Node">The node.</param>
        ///// <returns></returns>
        //public static List<double> Averages_of_Levels(TreeNode root)
        //{
        //    List<Dictionary<int, List<int>>> levelWiseValues = new List<Dictionary<int, List<int>>>();
        //    int treeHeight = getTreeMaxHeight(root);
        //    for (int i = 1; i <= treeHeight; i++)
        //    {
        //        printGivenLevel(root, i);
        //    }

        //    return new List<double>();
        //}
        //static Dictionary<int, List<int>> levelItem = new Dictionary<int, List<int>>();
        //public static int printGivenLevel(TreeNode root, int level)
        //{
        //    if (root == null)
        //    {
        //        return  -1;
        //    }
        //    if (level == 1)
        //    {
        //        Console.Write(root.Data + " ");
        //        return root.Data;
        //    }
        //    else if (level > 1)
        //    {
        //        var Data = printGivenLevel(root.Left, level - 1);
        //        Data = printGivenLevel(root.Right, level - 1);
        //    }
        //    return -1;
        //}

        //private static void AddToDic(int Data, int level)
        //{
        //    if (Data != -1)
        //    {
        //        if (levelItem.ContainsKey(level))
        //        {
        //            levelItem[level].Add(Data);
        //        }
        //        else
        //        {
        //            levelItem.Add(level, new List<int>() { Data });
        //        }
        //    }
        //}

        //private static int getTreeMaxHeight(TreeNode root)
        //{
        //    if (root == null)
        //        return 0;

        //    int leftMaxHeight = getTreeMaxHeight(root.Left);
        //    int rightMaxHeight = getTreeMaxHeight(root.Right);

        //    return Math.Max(leftMaxHeight, rightMaxHeight) + 1;
        //}

        #endregion Commented Code
    }
}