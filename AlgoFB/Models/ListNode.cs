namespace AlgoFB.Models
{
    public class ListNode
    {
        public int Data;
        public ListNode Next;
        //For double linked list
        public ListNode Previous;

        public ListNode(int x)
        {
            Data = x;
        }
    }
}