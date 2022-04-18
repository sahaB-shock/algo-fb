using AlgoFB.Models;

namespace AlgoFB.DataStructure
{
    public class Stack_LIFO
    {
        ListNode _lastNode;
        //                                                                               \//
        //
        //   5     → 4          → 3      2         → 1
        //   lastNode
        //   add→
        //   remove--
        //                                                                               \//

        public void Push_Add(int data)
        {
            ListNode nodeToAdd = new ListNode(data);
            if (_lastNode == null)
                _lastNode = nodeToAdd;
            else
            {
                nodeToAdd.Next = _lastNode;
            }
            _lastNode = nodeToAdd;
        }
        public ListNode Remove_Pop()
        {
            //var newLastNode = _lastNode.Next;
            //var removedLastNode = _lastNode;
            //_lastNode = newLastNode;
            //return removedLastNode;

            if (_lastNode == null)
                return null;
            var removedLastNode = _lastNode;
            _lastNode = _lastNode.Next;
            return removedLastNode;
        }
    }
}