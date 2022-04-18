using AlgoFB.Models;

namespace AlgoFB.AlgoSorting
{
    public static partial class LinkedList_Problems
    {
        /*
        //1 → 2 → 3 → 4 → 5 → 6 → 7
        //0   1   2   3   4   5   6
        //If we insert at <<3rd>> (current value is 4) position.
        //I have delink. <3rd>> - 1 = <<2nd>> Position,
        //1 → 2 → 3   new Node → 4 → 5 → 6 → 7
        //0   1   2      3       4   5   6   7

         */

        /// <summary>
        /// Inserts the node in linked list at given position.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="position">The position.</param>
        /// <param name="Data">The Data.</param>
        /// <returns></returns>
        public static ListNode Insert_Node_In_LinkedList_At_Given_Position(ListNode head, int position, int Data)
        {
            var nodeToAdd = new ListNode(Data);
            //2
            // 1 → 2 → 3 → 4 → 5
            // 0   1   2   3   4
            // x   x
            if (head == null)
            {
                return nodeToAdd;
            }
            ListNode current = head;
            int iPosition = 0;
            while (iPosition <= position)
            {
                //1 → 2 → 3 → 4 → 5 → null
                //0   1   2   3   4
                //insert at 3
                //1 → 2 → 3 → 10→ 4 → 5 → null
                //        X
                //       2-1
                //         1 index
                // delink 1 index node.
                //de link the previous item
                if (iPosition == position - 1)//********
                {
                    var tmp = current.Next;
                    current.Next = nodeToAdd;
                    current.Next.Next = tmp;
                    break;
                }

                iPosition++;
                current = current.Next;
            }

            return head;
        }
    }
}