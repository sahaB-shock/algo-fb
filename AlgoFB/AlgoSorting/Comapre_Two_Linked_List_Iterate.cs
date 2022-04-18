using AlgoFB.Models;

namespace AlgoFB.AlgoSorting
{
    public static partial class LinkedList_Problems
    {
        /// <summary>
        /// Comapres the two linked list.
        /// </summary>
        /// <param name="head1">The head1.</param>
        /// <param name="head2">The head2.</param>
        /// <returns></returns>
        public static bool Comapre_Two_Linked_List_Iterate(ListNode head1, ListNode head2)
        {
            if (head1 == null || head2 == null)
                return false;

            while (head1 != null || head2 != null)
            {
                var current1 = head1 != null ? head1 : null;
                var current2 = head2 != null ? head2 : null;
                if (current1 == null || current2 == null)
                    return false;

                /*if (current1 == null && current2 == null)
                    return true;*/

                if (current1.Data != current2.Data)
                    return false;

                head1 = head1.Next;
                head2 = head2.Next;
            }
            return true;
        }
    }
}