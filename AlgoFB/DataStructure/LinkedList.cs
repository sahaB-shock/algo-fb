using AlgoFB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.DataStructure
{
    public class LinkedList
    {
        private ListNode _head;
        private ListNode _lastNode;

        public static ListNode AddNodeByArrayInt(int[] array)
        {
            LinkedList linkedList = new LinkedList();

            for (int i = 0; i < array.Length; i++)
            {
                linkedList.AddToLast(array[i]);
            }

            return linkedList.GetHead();
        }

        public void AddToLast(int data)
        {
            ListNode nodeToAdd = new ListNode(data);

            if (_head == null)
            {
                _head = nodeToAdd;
                _lastNode = nodeToAdd;
            }
            else
            {
                _lastNode.Next = nodeToAdd;
                //This is optional//Without this line Linked List will work
                _lastNode = nodeToAdd;
            }
        }

        public void InsertNodeAtHead(int value)
        {
            var newNode = new ListNode(value);
            newNode.Next = _head;
            _head = newNode;//************************
        }
        public static ListNode InsertNodeAtHead(ListNode head, int value)
        {
            var newNode = new ListNode(value);
            if (head == null)
                return newNode;
            newNode.Next = head;
            return newNode;

        }

        public void DeleteFromLinkedList(ListNode head, int dataToDelete)
        {
            if (head == null)
                return;

            //If we want to delete value of head
            if (head.Data == dataToDelete)//************************ 
            {
                head = head.Next;
                return;
            }
            var current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == dataToDelete)
                {
                    current.Next = current.Next.Next;//*************
                    return;
                }
                current = current.Next;
            }
        }

        public ListNode DeleteFromLinkedList_ReturnHead(ListNode head, int dataToDelete)
        {
            if (head == null)
                return null;

            //If we want to delete value of head
            if (head.Data == dataToDelete)//************************ 
            {
                head = head.Next;
                return head;
            }

            var current = head;
            while (current.Next != null)
            {
                if (current.Next.Data == dataToDelete)
                {
                    current.Next = current.Next.Next;//***********
                    break;
                }
                current = current.Next;
            }
            return head;
        }

        public ListNode Head
        {
            get
            { return _head; }
        }
        public ListNode GetHead()
        {
            return _head;
        }

        public ListNode GetLast()
        {
            return _lastNode;
        }

        public static void PrintLinkedList(ListNode head)
        {
            while (head != null)
            {
                Console.Write($"{head.Data} > ");
                head = head.Next;
            }
            Console.WriteLine(" ");
        }
        /// <summary>
        /// Reverses the linked list recusion print.
        /// </summary>
        /// <param name="head">The head.</param>
        public static void Reverse_LinkedList_Recusion_Print(ListNode head)
        {
            if (head == null)
                //{
                return;
            //}
            //else {
            Reverse_LinkedList_Recusion_Print(head.Next);
            Console.Write($"{head.Data} > ");
            //}
        }





        public static long SumOfAllLinkedListValue(ListNode headNode)
        {
            string sum = "";
            while (headNode != null)
            {
                sum += headNode.Data;
                Console.Write($"{headNode.Data} ");
                headNode = headNode.Next;
            }
            return Convert.ToInt64(sum);
        }
    }
}
