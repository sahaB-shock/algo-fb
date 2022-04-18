using AlgoFB.Models;

namespace AlgoFB.DataStructure
{
    public class DoubleLinkedList
    {
        private ListNode _head = null;

        //private ListNode _previous;
        private ListNode _lastNode = null;

        public void AddToLast(int data)
        {
            /*
            //Add 1,2
            //Double Linked List Look like
            //1* → 2
            //* is head
            ListNode nodeToAdd = new ListNode(data);
            if (_head == null)
            {
                _head = nodeToAdd;
                _lastNode = nodeToAdd;
            }
            else
            {
                _lastNode.Next = nodeToAdd;
                nodeToAdd.Previous = _lastNode;
                _lastNode = nodeToAdd;
            }
            */




            //Add 1,2
            //Double Linked List Look like
            //2* → 1
            //* is head
            /* 1. allocate node  
            * 2. put in the data */
            ListNode nodeToAdd = new ListNode(data);


            /* 3. Make next of new node as head and previous as NULL */
            //nodeToAdd.Next = null;// when _head is empty;
            nodeToAdd.Next = _head;// when _head is empty;
            nodeToAdd.Previous = null;// when _head is empty;

            /* 4. change prev of head node to new node */
            if (_head != null)
            {
                _head.Previous = nodeToAdd;
            }
            else {
                _lastNode = nodeToAdd;
            }

            /* 5. move the head to point to the new node */
            _head = nodeToAdd;
            
        }

        public ListNode Head
        {
            get
            {
                return _head;
            }
        }

        public ListNode Last
        {
            get
            {
                return _lastNode;
            }
        }
    }
}