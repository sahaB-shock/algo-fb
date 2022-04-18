using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.DataStructure
{
    public class Queue_FIFO
    {
        ListNode _lastNode = null; //Add/Enqueue here
        ListNode _firstNode = null; //Remove/Dequeue from here
        //                                                                               \//
        //
        //   5     ← 4          ← 3      ←2         ← 1
        //   lastNode                                firstNode
        //   add←                                    remove (push next item as new firstNode)←
        //   add←new node's next is previous lastNode     
        //                                                                               \//

        public void Add_Enqueue(int data)
        {
            //change lastnode
            //add last position
            ListNode nodeToAdd = new ListNode(data);
            if (_lastNode != null)
            {
                _lastNode.Previous = nodeToAdd;
            }
            _lastNode = nodeToAdd;
            if (_firstNode == null)
            {
                _firstNode = nodeToAdd;
            }
        }

        public int? Remove_Dequeue()
        {
            if (_firstNode == null)
                return null;

            var val = _firstNode.Data;
            _firstNode = _firstNode.Previous;

            if (_firstNode == null)
                _lastNode = null;
            
            return val;

        }



        public int Peek()
        {
            if (_firstNode == null)
            {
                return -1;
            }
            return _firstNode.Data;
        }


        public bool IsEmpty()
        {
            return _firstNode == null;
        }
    }
}
