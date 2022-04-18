using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class LinkedList_Problems
    {
        /// <summary>
        /// Determines whether if Linked List has cycle.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <returns>
        ///   <c>true</c> if [is cycle linked list with hash set] [the specified head]; otherwise, <c>false</c>.
        /// </returns>
        public static bool Is_Cycle_LinkedList_With_HashSet(ListNode head)
        {
            //How to make linked list cyclic 
            ////////////////////////////////////////////////////////////////head.Next.Next.Next = head;

            //1 → 2 → 3 → 4
            //        ↑   ↓  
            //        6 ← 5  
            //              
            //
            /*
            Use Hashing:
            Traverse the list one by one and keep putting the node addresses in a Hash Table. At any point, if NULL is reached then return false and if Next of current node points to any of the previously stored nodes in Hash then return true.
             
             */

            if (head == null)
            {
                return false;
            }
            else
            {
                HashSet<ListNode> previousNodes = new HashSet<ListNode>();
                while (head.Next != null)
                {
                    previousNodes.Add(head);
                    if (previousNodes.Contains(head.Next))
                    {
                        return true;
                    }
                    head = head.Next;
                }
                return false;
            }
        }

        public static bool Is_Cycle_LinkedList_With_LastVisted_in_ListNode(ListNode head)
        {
            if (head == null)
                return false;

            while (head.Next != null)
            {
                //head.LastVisited=true;
                //if (head.LastVisited)
                //{
                //    return true;
                //}
                //head = head.Next;
            }
            return false;
        }
    }
}
