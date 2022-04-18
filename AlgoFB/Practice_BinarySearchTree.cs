using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.
public class VDistance
{
    public int Min;
    public int Max;
}
public class Practice_BinaryTree
{
    public static void CheclIfBSTIsValid()
    {
        BST bST = new BST();
        bST.Insert(2);
        bST.Insert(1);
        var root = bST.Insert(3);

        var isValidBST = IsValidBST(root);
    }
    public static void Practice_BinaryTree_Test()
    {



        BST bst = new BST();
        bst.Insert(6);
        bst.Insert(4);
        bst.Insert(3);
        bst.Insert(5);
        bst.Insert(8);
        bst.Insert(7);
        bst.Insert(9);
        bst.Insert(10);
        //bst.Insert(2);
        var root = bst.Insert(1);
        /*
                            6
                         4    8
                        3 5  7 9
                       1        10
                      
        Pre Order: 6 4 3 1 5 8 7 9 10      
        In Order:  1 3 4 5 6 7 8 9 10
        Post Orde: 1 3 5 4 7 9 10 8 6
    Vertical Orde: 1 3 5 5 6 7 8 9 10
    Top View: 1 3 4 6 8 9 10
        */
        var preorder = PreOrder_Non_Recursive(root);
        var lst = InOrder_Sort_Asc_Non_Recursive(root);
        Console.WriteLine($"Contains 10 {bst.Contains_BST(root, 11)}");

        InOrder_Print(root);
        Console.WriteLine("InOrder");
        PreOrder_Print(root);
        Console.WriteLine("Pre Order");
        PostOrder_Print(root);
        Console.WriteLine("Post Order");
        Level_Order_Print(root);
        Console.WriteLine("Level Order");
        Vertical_Print(root);
        Vertical_Print_2(root);


        Console.WriteLine("Node Count (Recursive) " + Total_Node_Count(root));
        Console.WriteLine("Node Count (Queue/Breadth) " + Total_Node_Count_Breadth(root));


        Console.WriteLine("Tree Height (Recursive) " + Tree_Height(root));

    }
    public static bool IsValidBST(TreeNode root)
    {
        return Check(root, Left: null, Right: null);
    }

    public static bool Check(TreeNode root, TreeNode Left, TreeNode Right)
    {
        if (root == null)
            return true;

        if (Left != null && Left.Data >= root.Data)
        {
            return false;
        }

        if (Right != null && Right.Data <= root.Data)
        {
            return false;
        }

        var final = Check(root.Left, Left, root) && Check(root.Right, root, Right);
        return final;
    }
    static void Vertical_Print_2_Helper(TreeNode node, int vLine, int hd)
    {
        if (node == null)
            return;

        if (hd == vLine)
            Console.Write($"{node.Data} ");

        Vertical_Print_2_Helper(node.Left, vLine, hd - 1);
        Vertical_Print_2_Helper(node.Right, vLine, hd + 1);

    }

    static void Vertical_Print_2(TreeNode node)
    {
        VDistance vd = new VDistance();
        Get_Min_Max_Distance(node, 0, vd);

        for (int i = vd.Min; i <= vd.Max; i++)
        {
            Vertical_Print_2_Helper(node, i, 0);
        }
        Console.WriteLine("Vertical Print class Min Max");
    }
    static void Get_Min_Max_Distance(TreeNode node, int height, VDistance vd)
    {
        if (node == null)
            return;
        if (height < 0)
        {
            vd.Min -= 1;
        }
        if (height > 0)
        {
            vd.Max += 1;
        }

        Get_Min_Max_Distance(node.Left, height - 1, vd);
        Get_Min_Max_Distance(node.Right, height + 1, vd);


    }
    static void Vertical_Print(TreeNode node)
    {
        SortedDictionary<int, List<int>> v_nodes = new SortedDictionary<int, List<int>>();
        Vertical_Print(node, 0, v_nodes);
        Console.WriteLine($"Sorted Dictionary Min {v_nodes.First().Key} Max {v_nodes.Last().Key}");
        foreach (var item in v_nodes)
        {
            Console.Write($"{string.Join(" ", item.Value)} ");
        }
        Console.WriteLine("Vertical Print (Sorted Dictionary)");
    }
    static void Vertical_Print(TreeNode node, int distance, SortedDictionary<int, List<int>> v_nodes)
    {
        if (node == null)
            return;

        if (!v_nodes.ContainsKey(distance))
        {
            v_nodes.Add(distance, new List<int>() { node.Data });
        }
        else
        {
            v_nodes[distance].Add(node.Data);
        }


        Vertical_Print(node.Left, distance - 1, v_nodes);
        Vertical_Print(node.Right, distance + 1, v_nodes);

    }

    static void Level_Order_Print(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Queue<TreeNode> qu = new Queue<TreeNode>();
        qu.Enqueue(node);

        while (qu.Count > 0)
        {
            var tmp = qu.Dequeue();
            Console.Write($"{tmp.Data} ");
            if (tmp.Left != null)
            {
                qu.Enqueue(tmp.Left);
            }
            if (tmp.Right != null)
            {
                qu.Enqueue(tmp.Right);
            }
        }

    }
    static int Total_Node_Count(TreeNode root)
    {
        if (root == null)
            return 0;

        var count = 1;
        count += Total_Node_Count(root.Left);
        count += Total_Node_Count(root.Right);
        return count;
    }

    static int Total_Node_Count_Breadth(TreeNode node)
    {
        if (node == null)
        {
            return 0;
        }

        Queue<TreeNode> qu = new Queue<TreeNode>();
        qu.Enqueue(node);
        int nodeCount = 1;
        int height = 0;
        int l_height = 0;
        int r_height = 0;
        while (qu.Count > 0)
        {

            var tmpNode = qu.Dequeue();
            if (tmpNode.Left != null)
            {
                qu.Enqueue(tmpNode.Left);
                nodeCount++;

                l_height++;
            }
            if (tmpNode.Right != null)
            {
                qu.Enqueue(tmpNode.Right);
                nodeCount++;

                r_height++;
            }

        }
        height = Math.Max(r_height, l_height);
        Console.WriteLine("height by breadth " + height);
        return nodeCount;
    }




    static int Tree_Height(TreeNode node)
    {
        if (node == null)
            return 0;

        var left_height = Tree_Height(node.Left);
        var right_height = Tree_Height(node.Right);
        return Math.Max(left_height, right_height) + 1;
    }

    static void PostOrder_Print(TreeNode node)
    {
        if (node == null)
            return;
        PostOrder_Print(node.Left);
        PostOrder_Print(node.Right);
        Console.Write($"{node.Data} ");
    }

    static void PreOrder_Print(TreeNode node)
    {
        if (node == null)
            return;
        Console.Write($"{node.Data} ");
        PreOrder_Print(node.Left);
        PreOrder_Print(node.Right);
    }
    static void InOrder_Print(TreeNode node)
    {
        if (node == null)
            return;

        InOrder_Print(node.Left);
        Console.Write($"{node.Data} ");
        InOrder_Print(node.Right);
    }
    public static List<int> InOrder_Sort_Asc_Non_Recursive(TreeNode root)
    {
        List<int> lst = new List<int>();
        if (root == null)
            return lst;

        Stack<TreeNode> st = new Stack<TreeNode>();
        /*
                            6
                         4    8
                        3 5  7 9
                       1        10
                       
            1 3 4 5 6 7 8 9 10
            
        */
        while (true)
        {

            if (root != null)
            {
                st.Push(root);
                root = root.Left;
            }

            if (root == null)
            {
                if (st.Count == 0)
                    break;

                var tmp = st.Pop();//1
                lst.Add(tmp.Data);
                root = tmp.Right;
            }

        }
        return lst;
    }
    /// <summary>
    /// Pres the order non recursive. Ref: https://www.geeksforgeeks.org/iterative-preorder-traversal/
    /// </summary>
    /// <param name="root">The root.</param>
    /// <returns></returns>
    public static IList<int> PreOrder_Non_Recursive(TreeNode root)
    {
        /*
                            6
                         4    8
                        3 5  7 9
                       1        10

        6 4 3 1 5 8 7 9 10
        */

        List<int> lst = new List<int>();
        if (root == null)
            return lst;

        Stack<TreeNode> st = new Stack<TreeNode>();
        st.Push(root);
        while (st.Count > 0)
        {
            var tmp = st.Pop();
            lst.Add(tmp.Data);

            if (tmp.Right != null)
            {
                st.Push(tmp.Right);
            }

            if (tmp.Left != null)
            {
                st.Push(tmp.Left);
            }
        }
        return lst;
    }
}

public class BST
{
    TreeNode _root = null;

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
        if (root.Data > data)//Left less
        {
            root.Left = insertNode(root.Left, data);
        }
        else
        {
            root.Right = insertNode(root.Right, data);
        }
        return root;
    }

    public bool Contains_BST(TreeNode node, int data)
    {
        if (node == null)
            return false;

        if (node.Data == data)
            return true;

        if (node.Data > data)
            return Contains_BST(node.Left, data);
        else
            return Contains_BST(node.Right, data);

    }

}

public class TreeNode
{
    public TreeNode(int data)
    {
        Data = data;
    }
    public TreeNode Left;
    public TreeNode Right;
    public int Data;
}
