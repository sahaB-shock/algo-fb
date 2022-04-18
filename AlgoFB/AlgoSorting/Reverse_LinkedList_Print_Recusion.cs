using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.AlgoSorting
{
    public static partial class LinkedList_Problems
    {
        public static void Reverse_LinkedList_Print_Recusion(ListNode head)
        {
            if (head == null)
                //{
                return;
            //}
            //else {
            Reverse_LinkedList_Print_Recusion(head.Next);
            Console.Write($"{head.Data} > ");
            //}
        }
    }
}
