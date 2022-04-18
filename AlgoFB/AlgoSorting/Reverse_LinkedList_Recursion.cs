using AlgoFB.Models;

namespace AlgoFB.AlgoSorting
{
    public static partial class LinkedList_Problems
    {
        public static ListNode Reverse_LinkedList_Recursion(ListNode head)
        {
            if (head == null)
                return null;

            if (head.Next == null)
                return head;//5

            ListNode previous = Reverse_LinkedList_Recursion(head.Next);
            //Execution will wait here
            //Below line will only start executuing if head.Next = null
            //4   //5 //null   //4
            head.Next.Next = head; //5 →  4//WOW
            //4  //null
            head.Next = null; //4 → null;
            return previous;//4,3,2,1
        }
    }
}