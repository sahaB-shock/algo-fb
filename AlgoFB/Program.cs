using AlgoFB.AlgoProblem;
using AlgoFB.AlgoSorting;
using AlgoFB.DataStructure;
using AlgoFB.MathProblem;
using AlgoFB.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static AlgoFB.AlgoProblem.Algo;

namespace AlgoFB
{
    public class CustomCompare : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x.Length > y.Length)
                return 1;
            else if (x.Length < y.Length)
                return -1;
            else
            {
                if (x == y)
                    return 0;
                else
                {
                    var i = 0;
                    while (x[i] == y[i])
                    {
                        i++;
                    }
                    return x[i].CompareTo(y[i]);
                }
            }
        }
    }

    internal class Program
    {
        
        private static void Main(string[] args)
        {
            Algo.Message_Encryption("haveaniceday");

            var resDiv = Algo.Divide_Two_Integers_No_Operator_Timed_Out(-2147483648, -1);

            var matrix = Algo.GenerateMatrix(3);
            int[] range_sum = new int[] { 1, 2, 3, 4, 5, 6 };
            Array_Range_Sum_Query_Mutable_Sqrt_Decomposition range_mut = new Array_Range_Sum_Query_Mutable_Sqrt_Decomposition(range_sum);

            List<List<int>> arr1 = new List<List<int>>() {
                new List<int>(){ 1 ,2,3},
                new List<int>(){ 4 ,5,6},
                new List<int>(){ 9 ,8,9}
            };
            int sign = ((10 < 0) ^ (10 < 0)) ? -1 : 1;
            int[] array_large_sum_contiguous_sun_array = new int[] { -163, -20 };
            //int[] array_large_sum_contiguous_sun_array = new int[] { -10, -11 - 13, -2, -1 };

            //int[] array_large_sum_contiguous_sun_array = new int[] { -2, 1 - 3, 4, -1, 2, 1, -5, 4 };
            var largest_sum = Algo.MaxSubArray_Largest_Sum_Contiguous_Subarray(array_large_sum_contiguous_sun_array);

            int[] arr_swap_mi = new int[] { 2, 3, 4, 1, 5 };
            Algo.Minimum_Swap_Count_Map(arr_swap_mi);
            string reverse = "babin Saha Test";
            string reversed_sentence = Algo.Sentence_Reverse(reverse);
            var lastIndex = reverse.LastIndexOf(' ');
            reverse.Substring(lastIndex, reverse.Length - lastIndex);
            reverse = reverse.Replace(reverse.Substring(lastIndex, reverse.Length - lastIndex), "");


            List<People> ppl = new List<People>() {
            new People(){ BirthYear = 2000, DeathYear = 2080 },
            new People(){ BirthYear = 1980, DeathYear = 1999 }
            };
            Algo.Max_Alive_Years_Population(ppl);

            Stack<char> stkc = new Stack<char>();

            Practice_BinaryTree.Practice_BinaryTree_Test();
            var sqrt_algo = MathTest.Square_Root(82);

            int[] aRearrange = new int[] { 2, 0, 1 };
            Algo.Array_Re_Arrange(aRearrange);
            LinkedList lstPali = new LinkedList();
            lstPali.AddToLast(1);
            lstPali.AddToLast(2);

            LinkedList_Problems.IsPalindrome_LinkedList(lstPali.GetHead());

            List<long> lst = new List<long>() { 1, 3, 3, 9, 9, 9, 27, 81 };
            var triplets = Algo.CountTriplets_Count_Triplets_GeoMatric_Progession(lst, 3);
            Console.WriteLine($"Triplets {triplets}");
            //Algo.Find_All_Anagrams_in_a_String("cbaebabacd", "cba");
            Algo.Find_All_Anagrams_in_a_String("aa", "bb");

            int[] birthday_candels = new int[] { 1, 2, 3, 8, 8, 6, 8, 4 };
            //output 2345
            int[] sorted_array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            SortingAlgo.Binary_Search_In_Sorted_Array_Non_Recursive(sorted_array, 0, sorted_array.Length - 1, 4);
            SortedDictionary<int, int> sdic = new SortedDictionary<int, int>();
            int max = 0;
            for (int i = 0; i < birthday_candels.Length; i++)
            {
                //max = Math.Max(max, birthday_candels[i]);
                if (!sdic.ContainsKey(birthday_candels[i]))
                {
                    sdic.Add(birthday_candels[i], 1);
                }
                else
                {
                    sdic[birthday_candels[i]] += 1;
                }
            }
            max = sdic.Last().Value;
            Console.WriteLine($"{max}");



            var lstSubStr = Practice.Get_All_Possible_SubString("abcde");
            var isVaildSherlockString = Algo.Sherlock_and_the_Valid_String("aabbccddeefghi");

            Algo.Two_Word_Anagram_Deletion_Count("showman", "woman");
            string ax = " aaaaaaaaa";
            Array.Reverse(ax.ToCharArray());
            var bx = new string(new char[] { ax[0] });
            Algo.New_Year_Chaos_Swap(new int[] { 2, 1, 5, 3, 4 });
            //Practice.Check_Magazine_Word_Ransome_Easy("two times three is not four", "two times two is four");

            var to_the_power = Algo.Math_Pow_Algo_Optimized(2, -2);
            int[] A = new int[] { 4, 6, 5, 1, 2 };

            Practice.Selection_Sort_Move_Min_At_Beginning(A);
            int[] array_sum = new int[] { 3, 3, 6, 5, -2, 2, 5, 1, -9, 4 };
            bool is_three_part = (array_sum.Sum() % 3 == 0);
            //Algo.Math_Pow_Algo(0.445, 0);
            int[,] rotated_matrix = Algo.RotateMatrix();

            var median = Algo.Find_The_Median_Of_Sorted_Array(new int[] { 1, 2 }, new int[] { 3, 4 });
            var leb_unq = Algo.Longest_Substring_Without_Repeating_Characters("pwwkew");


            List<int> lstRemove_test = new List<int>() { 1, 2, 3, 4, 5 };

            int[] art = new int[] { 1, 2, 3 };
            var to = art.Sum();//WOW

            Array.Resize(ref art, 20);//WOW

            Min_Heap min_Heap = new Min_Heap(10);
            min_Heap.Add_Value_Push(286789035);
            min_Heap.Add_Value_Push(255653921);
            min_Heap.Add_Value_Push(274310529);
            min_Heap.Add_Value_Push(494521015);
            //var minval = min_Heap.Delete_Pop_Poll_Node();
            var minval = min_Heap.Get_Value_Peek();
            //Queue1_HackerRank();

            Array.Copy(art, 0, art, 0, 20);
            var bigSorting = new string[] { "123", "111", "12312312", };
            Array.Sort(bigSorting, new CustomCompare());//WOW

            int[] arr_qk = new int[] { 5, 8, 1, 3, 7, 9, 2 };

            //Practice.Quick_Sort(arr_qk, 0, arr_qk.Length - 1);
            SortingAlgo.Sorting_Quick_Sort_O_NLogN(arr_qk);
            int[] arr_qk_2 = new int[] { 5, 8, 1, 3, 7, 9, 2 };
            SortingAlgo.Quick_Sort(arr_qk_2, 0, arr_qk_2.Length - 1);

            #region Binary Search Tree or Binary Tree

            Binary_Search_Tree bst = new Binary_Search_Tree();
            bst.Insert(10);
            bst.Insert(20);
            bst.Insert(9);
            bst.Insert(5);
            bst.Insert(6);
            bst.Insert(19);
            bst.Insert(39);
            bst.Insert(29);
            bst.Insert(89);
            bst.Insert(31);
            bst.Insert(42);
            bst.Insert(65);
            var tRoot = bst.Insert(8);
            var tree_root_height = Binary_Search_Tree.MaxHeight(tRoot);
            var nodesCount = Binary_Search_Tree.Nodes_Count_Recursive(tRoot);
            var tree_contains_val = Binary_Search_Tree.Contains(100, tRoot);
            var BStree_contains_val = Binary_Search_Tree.Contains_In_Binary_Search_Tree(5, tRoot);

            Binary_Search_Tree binarySearchTree = new Binary_Search_Tree();
            binarySearchTree.Insert(6);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(3);
            binarySearchTree.Insert(5);
            binarySearchTree.Insert(8);
            binarySearchTree.Insert(7);
            binarySearchTree.Insert(9);
            binarySearchTree.Insert(10);
            var root = binarySearchTree.Insert(1);

            /*
                            6
                         4    8
                        3 5  7 9
                       1        10

             Pre Order  = 6 4 3 1 5 8 7 9 10
             In Order   = 1 3 4 5 6 7 8 9 10
             Post Order = 1 3 6 4 7 9 9 10 6
             */
            SortedDictionary<int, List<int>> distance_disctionay = new SortedDictionary<int, List<int>>();
            Binary_Search_Tree.Get_Vertical_Distance(root, 0, distance_disctionay);

            var hz_dis = new Horizontal_Left_Right_Dis();
            Binary_Search_Tree.Get_Mini_Left_Max_Right_Horizontal_Distance_Tree(root, hz_dis, 0);
            var array = distance_disctionay.Select(x => x.Value).ToList();
            var ht1 = Binary_Search_Tree.MaxHeight(root);
            var dp1 = Binary_Search_Tree.MaxDepth(root);
            var nodeCount = Binary_Search_Tree.Nodes_Count_Recursive(root);
            var nodesCount_Recursive = Binary_Search_Tree.Nodes_Count_Recursive(root);
            var nodesCount_Queue = Binary_Search_Tree.Nodes_Count_Breadth_First_Traversal(root);
            var height_from_nodesCount = Math.Log2(nodesCount_Recursive + 1) - 1;//Complete Tree Only
            Binary_Search_Tree.Level_Breadth_Order_Traversal_Print(root);
            Binary_Search_Tree.Level_Breadth_Order_Traversal_Print_New_Line(root);
            Console.Write("Pre Order ");
            Binary_Search_Tree.Pre_Order_Traversal_Print(root); Console.WriteLine();
            Console.Write("In Order ");
            Binary_Search_Tree.In_Order_Traversal_Print(root); Console.WriteLine();
            Console.Write("Post Order ");
            Binary_Search_Tree.Post_Order_Traversal_Print(root); Console.WriteLine();

            var array_of_avg_list = Binary_Search_Tree.Average_of_Level_Non_Recursive(root);
            array_of_avg_list = Binary_Search_Tree.Average_of_Level_Recursive(root);

            #endregion Binary Search Tree or Binary Tree

            var seven_nodes_tree_height = Math.Log2(7);
            int[] insertionSort_Advance = new int[] { 2, 1, 3, 1, 2 };//Shift Count = 4
            int[] insertionSort_Advance_2 = new int[] { 1, 1, 1, 2, 2 };//Shift Count = 0
            int[] insertionSort_Advance_3 = new int[] { 12, 15, 1, 5, 6, 14, 11 };//Shift Count = 5
            int[] insertionSort_Advance_4 = new int[] { 3, 5, 7, 11, 9 };//Shift Count = 2
            Insertion_Sort_Shift_Count_Advance_Analysis(insertionSort_Advance_4);

            var shifCount = SortingAlgo.Sorting_3_Insertion_Sort_Left_Shift_Count(insertionSort_Advance_3);
            shifCount = SortingAlgo.Sorting_3_Insertion_Sort_Left_Shift_Count(insertionSort_Advance_2);

            int[] unsorted_1 = new int[] { 8, 5, 6, 3, 1 };
            SortingAlgo.Sorting_Bubble_Sort_On2_Optimized(unsorted_1);
            unsorted_1 = new int[] { 8, 5, 6, 3, 1 };
            SortingAlgo.Sorting_Merge_ONlogN(unsorted_1);
            PrintArray(unsorted_1);
            var unsorted_2 = new int[] { 8, 5, 6, 3, 1 };
            SortingAlgo.Sorting_Insertion_Sort_On2_Worst(unsorted_2);
            PrintArray(unsorted_2);

            var comSum = Algo.Colorful_Number(123);
            Stack_Array_Size<string> stackArray = new Stack_Array_Size<string>(5);
            stackArray.Push("Babin");
            stackArray.Push("Arpita");
            stackArray.Push("Todo");
            stackArray.Push("Manju");
            stackArray.Push("Ashok");//Last In
            stackArray.Push("Test");//Overflow

            var firstOut = stackArray.Pop();//Last In is First Out //Ashok
            firstOut = stackArray.Pop();//Last In is First Out //Manju;

            stackArray.Push("4th Element");//Overflow

            //Algo.Array_Power_Set<int>(new int[] { 1, 2, 3, 4, 5 });
            Algo.Is_To_The_Power_Of_Two(14);
            //Algo.Array_Power_Set<int>(new int[] { 1, 2, 3 });
            var indicies = icecreamParlor(5, new int[] { 1, 2, 6, 4, 5 });
            var indi = Algo.Find_Indexes_Of_Two_Item_In_Array_Matches_TargetSum(new int[] { 1, 2, 3, 4, 5 }, 5);
            var fib = Fib(7);
            Queue_With_Two_Stacks<int> queue_With_Two_Stacks = new Queue_With_Two_Stacks<int>();
            queue_With_Two_Stacks.Enqueue(10);//firstNode
            queue_With_Two_Stacks.Enqueue(20);
            queue_With_Two_Stacks.Enqueue(30);

            //Queue_With_Two_Stacks queue_With_Two_Stacks = new Queue_With_Two_Stacks();
            //queue_With_Two_Stacks.Enqueue(10);//firstNode
            //queue_With_Two_Stacks.Enqueue(20);
            //queue_With_Two_Stacks.Enqueue(30);
            //var fifo = queue_With_Two_Stacks.Dequeue();//10
            //fifo = queue_With_Two_Stacks.Dequeue();//20

            Stack_LIFO_Generics<char> stk2 = new Stack_LIFO_Generics<char>();
            stk2.Push('A');
            stk2.Push('B');
            stk2.Push('C');

            Stack_LIFO_Generics<int> stk = new Stack_LIFO_Generics<int>();
            stk.Push(10);
            stk.Push(20);
            stk.Push(30);
            var lastValue = stk.Pop();

            Queue queue = new Queue();
            //var r = queue.Peek();

            Stack st = new Stack();
            //var rt = st.Peek();

            Queue_FIFO qu = new Queue_FIFO();
            qu.Add_Enqueue(10);
            qu.Add_Enqueue(20);
            qu.Add_Enqueue(30);

            var dq = qu.Remove_Dequeue();//10  First in
            dq = qu.Remove_Dequeue();//20  2nd First in

            Stack_LIFO stck = new Stack_LIFO();
            stck.Push_Add(10);
            stck.Push_Add(20);
            stck.Push_Add(30);

            var lifo = stck.Remove_Pop();//30 : Last in
            lifo = stck.Remove_Pop();//20 : 2nd Last in

            DoubleLinkedList doubleLinkedList = new DoubleLinkedList();
            doubleLinkedList.AddToLast(1);

            //int[][] array_2d_1 = new int[2][3] { new int[] { 1, 2, 3 },new int[] { 4, 5 } };
            //int[,] array_2d_2 = new int[3,2]
            Algo.InsertItem_In_Linked_List(null, 2, 11);

            var primes = MathTest.GetAllPrimes(10);
            var t = SortingAlgo.Binary_Search_In_Sorted_1D_Array(null, 89, 0, 13);
            var index = Algo.FindFirstIndexInSentence("Babinsahasaha", "sahx");
            var rotatedArray = Algo.LeftRotate(new int[] { 1, 2, 3, 4, 5 }, 2);
            var rotatedArray_op = Algo.LeftRotate_Optimized(new int[] { 1, 2, 3, 4, 5 }, 5, 9);
            TwoDimensionalArray.ZigZagTowDimensionalArray(null);
            Algo.Sprial_Two_Dimensional_Array_ClockWise(null);
            //int x = 0, i = 10;
            //while (i > 0)
            //{
            //    x += i;
            //    i /= 2;
            //}

            var maxLengthOfUniqueCharSubStr = Algo.LengthOfLongestSubstring_Optimized("pwwkew");
            var aCount = Algo.RepeatedString("aba", 10);
            //var minSteps = Algo.JumpingCouldMinimumSteps(new int[] { 0, 0, 1, 0, 0, 1, 0 });
            var minSteps = Algo.JumpingCouldMinimumSteps(new int[] { 0, 0 });

            var ss = "BabinSAha";
            var strLast = ss.TakeLast(1);
            int? testNull_Colalescing = null;
            var result = testNull_Colalescing ??= 10;
            int testInput = 12;

            int[] ar2 = new int[] { 1, 2, 3, 4, 5, 8 };
            var indices = Algo.Find_Indexes_Of_Two_Item_In_Array_Matches_TargetSum(ar2, 4);
            Algo.ReverseArray(ar2);

            int[] ar = new int[] { 2, 1, 3, 5, 4, 8 };
            SortingAlgo.Sorting_Selection_ON2(ar);

            var l1 = LinkedList.AddNodeByArrayInt(new int[] { 9 });
            var l2 = LinkedList.AddNodeByArrayInt(new int[] { 1, 9 });
            var sumHead = Algo.Add_Numbers_In_Two_LinkedList(l1, l2);

            int[] Heightos26Chars = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            var area = Algo.DesignerPdfViewer(Heightos26Chars, "zaba");

            var valleyCount = Algo.CountValleyVisitCompleted(8, "UDDDUDUU");
            valleyCount = Algo.CountValleyVisitCompleted(12, "DUDDUUUUDDDU");
            var mountainCount = Algo.CountMountainVisitCompleted(12, "DUDDUUUUDDDU");

            var dummyNode = new ListNode(0);
            var tail = dummyNode;
            LinkedList linkedList = new LinkedList();
            linkedList.AddToLast(1);
            linkedList.AddToLast(2);
            linkedList.AddToLast(3);
            linkedList.AddToLast(4);
            linkedList.AddToLast(5);
            linkedList.AddToLast(6);

            LinkedList.InsertNodeAtHead(linkedList.Head, 100);

            /*Is linked list cycle*/
            //linkedList.Head.Next.Next = linkedList.Head;
            LinkedList_Problems.Is_Cycle_LinkedList_With_HashSet(linkedList.Head);

            var f_Head = linkedList.GetHead();
            LinkedList.PrintLinkedList(f_Head);
            f_Head = LinkedList_Problems.Reverse_LinkedList_Recursion(f_Head);
            LinkedList.PrintLinkedList(f_Head);
            f_Head = LinkedList_Problems.Reverse_LinkedList_WhileLoop(f_Head);
            LinkedList.PrintLinkedList(f_Head);
            f_Head = LinkedList_Problems.Reverse_LinkedList_WhileLoop(f_Head);

            #region Delete LinkedList For Given Value

            int deleteValue = 4;
            if (f_Head != null)
            {
                if (f_Head.Data == deleteValue)
                {
                    f_Head.Next = f_Head.Next.Next;
                }
                else
                {
                    var current = f_Head;
                    while (current.Next != null)
                    {
                        if (current.Next.Data == deleteValue)
                        {
                            current.Next = current.Next.Next;
                            break;
                        }
                        current = current.Next;
                    }
                }
            }
            f_Head = linkedList.DeleteFromLinkedList_ReturnHead(f_Head, 2);
            LinkedList.PrintLinkedList(f_Head);

            #endregion Delete LinkedList For Given Value

            int insertAt = 2;
            int insertValue = 200;
            ListNode insertNode = new ListNode(insertValue);
            if (f_Head != null)
            {
                if (insertAt == 0 || f_Head.Next == null)
                {
                    insertNode.Next = f_Head;
                }
                int iCounter = 0;
                var current = f_Head;
                while (iCounter <= insertAt)
                {
                    //1 → 2 → 3 → 4 → 5 → 6 → 7
                    //0   1   2   3   4   5   6
                    //If we insert at <<3rd>> (current value is 4) position.
                    //I have delink. <3rd>> - 1 = <<2nd>> Position,
                    //1 → 2 → 3   new Node → 4 → 5 → 6 → 7
                    //0   1   2      3       4   5   6   7
                    if (iCounter == insertAt - 1)/* Why -1,********/
                    {
                        var tmp = current.Next;
                        current.Next = insertNode;
                        insertNode.Next = tmp;
                        break;
                    }

                    current = current.Next;
                    iCounter++;
                }
            }
            LinkedList.PrintLinkedList(f_Head);

            linkedList.DeleteFromLinkedList(linkedList.GetHead(), 1);
            var hd = linkedList.GetHead();

            var sum = LinkedList.SumOfAllLinkedListValue(hd);
            Console.WriteLine(" ↑ Forward Print of Linked List");
            LinkedList.PrintLinkedList(hd);
            LinkedList.Reverse_LinkedList_Recusion_Print(hd);
            Console.WriteLine(" ↑ Reversed Print of Linked List");
            ///////////////////////////////////////////////////////////////////
            ///////////////////////// HASH TABLE //////////////////////////////
            ///////////////////////////////////////////////////////////////////
            Hashtable ht = new Hashtable();
            var test1 = ht.ContainsKey(1);
            test1 = ht.ContainsKey(1);
            ht.Add(1, 1);
            ht.Remove(1);
            ht.Add(1, 1);//Throw Exception
            ht.Add("1", "String1");

            var ht2Value = ht[1];
            ht2Value = ht["1"];//treat as dynamic.
            ///////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////
            ///////////////////////// KEY VALUE PAIR //////////////////////////
            ///////////////////////////////////////////////////////////////////
            var list = new List<KeyValuePair<string, int>>();
            list.Add(new KeyValuePair<string, int>("Cat", 1));
            list.Add(new KeyValuePair<string, int>("Dog", 3));
            list.Add(new KeyValuePair<string, int>("Rabbit", 4));

            ///////////////////////////////////////////////////////////////////

            var abc = Math.Max(1, 2);
            ///////////////////////////////////////////////////////////////////
            ///////////////////////// DICTIONARY //////////////////////////////
            ///////////////////////////////////////////////////////////////////
            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            dic2.Add("babin", 1);
            dic2.Add("Babin", 1);

            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(1, 2);
            dic.Add(1, 2);//Throws exception;
            dic.GetValueOrDefault(1);//WOW
            var dicVal = dic[1];
            dic.ContainsKey(1);
            int val = -1;
            dic.TryGetValue(1, out val);
            var aaaa = dic[1];
            ///////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////
            //////////////////////////// HASHSET //////////////////////////////
            ///////////////////////////////////////////////////////////////////
            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(1);
            hs.Contains(1);
            ///////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////
            //////////////////////////// SORTED LIST ///////////////////////////
            //////////////////////////// SORTED Dictionary /////////////////////
            ///////////////////////////////////////////////////////////////////
            SortedList sortedList = new SortedList();
            sortedList.Add("1", "B");
            //sortedList[]
            //sortedList.Add(2, "A");//Throws Expception

            SortedList<int, string> srtGenrics = new SortedList<int, string>(){
                { 1,"A"},
                { 1,"A"},
                { 1,"A"}
            }; ;
            //srtGenrics[]
            SortedDictionary<int, string> keyValuePairs = new SortedDictionary<int, string>();
            keyValuePairs.Add(1, "a");
            KeyValuePair<int, string> keyValuePair = new KeyValuePair<int, string>();

            ///////////////////////////////////////////////////////////////////

            var hashSetByIndex = hs.ToList()[0];

            int a = 0, b = 0;
            a++;
            ++b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = b = 0;
            var c = a++;
            var d = ++b;
            Console.WriteLine(c);
            Console.WriteLine(d);

            var test = Algo.OneEditApart("cat", "act");
            test = Algo.OneEditApart("cat", "cst");
            Console.WriteLine("Hello World!");
        }

        private static void Queue1_HackerRank()
        {
            Console.WriteLine("Please enter queris in new lines");
            List<List<string>> lstLines = new List<List<string>>();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                lstLines.Add(line.Split(new char[] { ' ' }).ToList());
            }
            Min_Heap heap = new Min_Heap(100000);
            //int last_minValue=-1;
            List<List<string>> lst = new List<List<string>>() {
                new List<string> { "1", "2" },
                new List<string> { "3", "4" }
            };
            foreach (var item in lstLines)
            {
                if (item[0] == "1")
                {
                    heap.Add_Value_Push(Convert.ToInt64(item[1]));
                }
                else if (item[0] == "2")
                {
                    heap.Delete_Pop_Poll_Node();
                }
                else if (item[0] == "3")
                {
                    Console.WriteLine(heap.Get_Value_Peek());
                }
            }
        }

        private static void PrintArray(int[] unsorted_1)
        {
            if (unsorted_1 != null)
            {
                for (int i = 0; i < unsorted_1.Length; i++)
                {
                    Console.Write($"{unsorted_1[i]} ");
                }
                Console.WriteLine(" ");
            }
        }

        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        private void Swap(int[] arr, int i, int j)
        {
            var tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }

        private static int[] icecreamParlor(int sum, int[] arr)
        {
            if (arr.Length == 0)
                return (int[])null;

            //1 2 3 4 5
            //m = 5
            //5 4 3 2
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                int val;

                var complement = sum - arr[i];
                if (!dic.ContainsKey(complement))
                {
                    dic.Add(complement, i);
                }
                if (dic.TryGetValue(arr[i], out val))
                {
                    return new int[] { val, i };
                }
            }

            return null;
        }

        private static void Insertion_Sort_Shift_Count_Advance_Analysis(int[] arr)
        {
            left_shift_count = 0;
            Merge_Sort(arr);
            Console.WriteLine($"Shift count in Insertion Sort {left_shift_count}");
        }

        private static void Merge_Sort(int[] arr)
        {
            if (arr.Length == 1)
                return;
            int mid = arr.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            Array.Copy(arr, 0, left, 0, mid);
            Array.Copy(arr, mid, right, 0, right.Length);

            Merge_Sort(left);
            Merge_Sort(right);

            Merge_Sorted_Array(left, right, arr);
        }

        private static int left_shift_count = 0;

        private static void Merge_Sorted_Array(int[] left, int[] right, int[] mainArray)
        {
            int iL = 0;
            int iR = 0;
            int iMain = 0;

            while (iL < left.Length && iR < right.Length)
            {
                if (left[iL] <= right[iR])
                {
                    mainArray[iMain] = left[iL];
                    iL++;
                }
                else//left[iL] >  right[iR])
                {
                    mainArray[iMain] = right[iR];
                    iR++;
                    left_shift_count += left.Length - iL;
                }
                iMain++;
            }
            //move all left over of left to the end of main
            while (iL < left.Length)
            {
                mainArray[iMain] = left[iL];
                iL++; iMain++;
            }
            //Move all left over right side to the main array
            while (iR < right.Length)
            {
                mainArray[iMain] = right[iR];
                iR++; iMain++;
            }
        }

        private static int[] quickSort(int[] arr)
        {
            int pivot_value = arr[0];
            int pivot_index = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] <= pivot_value)
                {
                    swap(arr, pivot_index, i);
                    pivot_index++;
                }
            }
            swap(arr, pivot_index, 0);

            return arr;
        }

        private static void swap(int[] arr, int i, int j)
        {
            var tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;
        }
    }
}