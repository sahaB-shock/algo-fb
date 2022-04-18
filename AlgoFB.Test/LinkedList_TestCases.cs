using AlgoFB.AlgoProblem;
using AlgoFB.AlgoSorting;
using AlgoFB.DataStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.Test
{
    [TestClass]
    public class LinkedList_TestCases
    {
        [TestMethod]
        public void Add_One_To_Array_Last_Element_Number_Leading_Zero()
        {
            List<int> A = new List<int>() { 0, 3, 7, 6, 4, 0, 5, 5, 5 };
            Algo.Add_One_To_Array_Last_Element_Number(A);
        }

        [TestMethod]
        public void Compare_Two_Linked_List_Same()
        {
            LinkedList linkedList_1 = new LinkedList();
            linkedList_1.AddToLast(1);
            linkedList_1.AddToLast(2);
            linkedList_1.AddToLast(3);

            LinkedList linkedList_2 = new LinkedList();
            linkedList_2.AddToLast(1);
            linkedList_2.AddToLast(2);
            linkedList_2.AddToLast(3);

            var same = LinkedList_Problems.Comapre_Two_Linked_List_Iterate(linkedList_1.Head, linkedList_2.Head);
            Assert.AreEqual(same, true);
        }

        [TestMethod]
        public void Compare_Two_Linked_List_One_Null()
        {
            LinkedList linkedList_1 = new LinkedList();
            linkedList_1.AddToLast(1);
            linkedList_1.AddToLast(2);
            linkedList_1.AddToLast(3);

            LinkedList linkedList_2 = new LinkedList();
            linkedList_2.AddToLast(1);
            linkedList_2.AddToLast(2);
            linkedList_2.AddToLast(3);

            var same = LinkedList_Problems.Comapre_Two_Linked_List_Iterate(null, linkedList_2.Head);
            Assert.AreEqual(same, false);
        }

        [TestMethod]
        public void Compare_Two_Linked_List_One_Diff_One_Less()
        {
            LinkedList linkedList_1 = new LinkedList();
            linkedList_1.AddToLast(1);
            linkedList_1.AddToLast(4);

            LinkedList linkedList_2 = new LinkedList();
            linkedList_2.AddToLast(1);
            linkedList_2.AddToLast(2);
            linkedList_2.AddToLast(3);

            var same = LinkedList_Problems.Comapre_Two_Linked_List_Iterate(linkedList_1.Head, linkedList_2.Head);
            Assert.AreEqual(same, false);
        }

        [TestMethod]
        public void Merge_Two_Linked_List_Sorted()
        {
            LinkedList linkedList_1 = new LinkedList();
            linkedList_1.AddToLast(1);
            linkedList_1.AddToLast(4);

            LinkedList linkedList_2 = new LinkedList();
            linkedList_2.AddToLast(1);
            linkedList_2.AddToLast(2);
            linkedList_2.AddToLast(3);

            var same = LinkedList_Problems.Merge_Two_LinkedList_In_Sorted_Iterate(linkedList_1.Head, linkedList_2.Head);
            Assert.AreEqual(same, false);
        }
    }
}
