using AlgoFB.DataStructure;
using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoProblem
{
    public static partial class Algo
    {
        /// <summary>
        /// Inserts the item in linked list.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="position_to_insert">The position.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public static ListNode InsertItem_In_Linked_List(ListNode head, int position_to_insert, int data)
        {
            if (head == null)
            {
                LinkedList linkedList = new LinkedList();
                linkedList.AddToLast(16);
                linkedList.AddToLast(13);
                linkedList.AddToLast(7);
                head = linkedList.GetHead();
            }

            if (head == null)
                return new ListNode(data);

            ListNode curr = head;
            int iPosition = 0;
            while (iPosition <= position_to_insert)
            {
                if (iPosition == position_to_insert - 1)
                {
                    var tmp = curr.Next;
                    curr.Next = new ListNode(data);
                    curr.Next.Next = tmp;
                    break;
                }

                iPosition++;
                curr = curr.Next;
            }

            return head;
        }
    }
}
