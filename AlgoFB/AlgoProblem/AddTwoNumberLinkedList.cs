using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {


        public static ListNode Add_Numbers_In_Two_LinkedList(ListNode l1, ListNode l2)
        {

            /*
                var l1 = LinkedList.AddNodeByArrayInt(new int[] { 9 });
                var l2 = LinkedList.AddNodeByArrayInt(new int[] { 1, 9 });

             */
            ListNode headOutput = null;
            ListNode lastNode = null;
            int sum = 0;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                sum = carry + (l1 != null ? l1.Data : 0) + (l2 != null ? l2.Data : 0);
                if (sum >= 10)
                {
                    carry = 1;
                }
                else {
                    carry = 0;
                }
                sum = sum % 10;// This will leave the carry 1., if sum is 10 or more. [9] + [1,9]
                ListNode nodeToAdd = new ListNode(sum);

                if (headOutput == null)
                {
                    headOutput = nodeToAdd;
                    lastNode = headOutput;
                }
                else
                {
                    lastNode.Next = nodeToAdd;
                    lastNode = lastNode.Next;
                }

                l1 = l1?.Next;
                l2 = l2?.Next;
            }
            if (carry > 0)//This case is for L1:{5} and L2 {6}
            {
                lastNode.Next = new ListNode(carry)
;
            }

            return headOutput;
        }

        internal static string Sentence_Reverse(string reverse)
        {
            //babin Saha Test
            int i = 0;
            //while (i < reverse.Length)
            //{
                
            //}
            return "";
        }
    }
}
