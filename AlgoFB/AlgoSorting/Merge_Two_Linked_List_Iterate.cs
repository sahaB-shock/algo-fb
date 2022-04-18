using AlgoFB.Models;
using System;
using System.Collections.Generic;

namespace AlgoFB.AlgoSorting
{
    public static partial class LinkedList_Problems
    {
        public static ListNode Merge_Two_LinkedList_In_Sorted_Recursion(ListNode head1, ListNode head2)
        {
            //TODO
            return null;
        }


        public static ListNode Merge_Two_LinkedList_In_Sorted_Iterate(ListNode A, ListNode B)
        {

            #region Sample Input Output
            /*
            1 2 3 4 5 6
            5 6
            o/p
            1 2 3 4 5 5* 6* 6
        
            1 2 4 5
            2 3 
            o/p
            1 2 2* 3* 4 5

            1 2 5 6 7 9 
            4 8
            o/p
            1 2 4* 5  6 7 8* 9

            null either or both

            3 5 6
            1 2
            o/p 1* 2* 3 5 6  
            */
            #endregion

            if (A == null)
                return B;

            if (B == null)
                return A;
            //get a new head to hold the result;
            ListNode result = new ListNode(-1);
            ListNode result_tmp_iteration_pointer = result;
            //Iteration
            while (true)
            {
                if (A == null)
                {
                    result_tmp_iteration_pointer.Next = B;
                    break;
                }
                if (B == null)
                {
                    result_tmp_iteration_pointer.Next = A;
                    break;
                }


                if (A.Data >= B.Data)
                {
                    result_tmp_iteration_pointer.Next = B;
                    B = B.Next;
                }
                if (A.Data <= B.Data)
                {
                    result_tmp_iteration_pointer.Next = A;
                    A = A.Next;
                }
                result_tmp_iteration_pointer = result_tmp_iteration_pointer.Next;

            }
            return result.Next; 
        }
    }
}