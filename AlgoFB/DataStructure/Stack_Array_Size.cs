using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoFB.DataStructure
{
    public class Stack_Array_Size<T>
    {
        T[] places = null;
        int top = -1;
        readonly int max = -1;
        public Stack_Array_Size(int size)
        {
            places = new T[size];
            max = size;
            top = -1;

        }
        

        public void Push(T data)
        {
            if (top == max - 1)
            {
                Console.WriteLine("OverFlow");
            }
            else
            {
                places[++top] = data;
            }
        }

        public T Pop()
        {
            if (top != -1)
            {
                return places[top--];
            }
            else
            {
                Console.WriteLine("Underflow");
                return default;
                //same as above//return default(T);
            }
        }


        public T Peek()
        {
            if (top == -1)
                return default(T);

            return places[top];
        }

        public int Count
        {
            get
            {
                return top+1;
            }
        }
    }
}
