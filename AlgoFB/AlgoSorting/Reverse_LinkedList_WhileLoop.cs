using AlgoFB.Models;
using System.Collections.Generic;

namespace AlgoFB.AlgoSorting
{
    public static partial class LinkedList_Problems
    {
        public static ListNode Reverse_LinkedList_WhileLoop(ListNode head)
        {
            ListNode current = head;
            ListNode Next = null;
            ListNode previous = null;
            while (current != null)
            {
                Next = current.Next;
                current.Next = previous;//WOW
                previous = current;
                current = Next;
            }
            head = previous;
            return head;
        }

        public static bool IsPalindrome_LinkedList(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            while (head != null)
            {
                stack.Push(head.Data);
                head = head.Next;
            }

            for (ListNode node = head; node != null; node = node.Next)
            {
                if (stack.Count > 0 && stack.Peek() == node.Data)
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}