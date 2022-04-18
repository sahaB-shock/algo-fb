using System.Collections;

/*
List<string> lstLine = new new List<string>();
int iCount = 0;
while ((line = Console.ReadLine()) != null) {
    // Do whatever you want here with line
    if(iCount != 0)
    {
        lstLine.Add(Console.ReadLine());
    }
    iCount++;
}
Queue_With_Two_Stacks q = new Queue_With_Two_Stacks();
if(lstLine?.Count > 0)
{
    foreach(var line in lstLine)
    {
        if(line.StartsWith("1"))
        {
            var value = line.Split(' ')[1];
            q.Enqueue(value);
        }
        else if(line.StartsWith("2"))
        {
            q.Dequeue();
        }
        else if(line.StartsWith("3"))
        {
            Console.WriteLine(q.Peek());
        }
    }
}

*/

namespace AlgoFB.DataStructure
{
    public class Queue_With_Two_Stacks<T>
    {
        //https://coderbyte.com/algorithm/implement-queue-using-two-stacks
        private Stack stack_Add = new Stack();

        private Stack stack_Remove = new Stack();
        private T _first_Entered_Data_In_Queue = default;
        public int Count { get; private set; } = 0;

        public void Enqueue(T data)
        {
            Count++;
            if (stack_Add.Count == 0)
            {
                _first_Entered_Data_In_Queue = data;
            }
            stack_Add.Push(data);
        }

        public T Peek()
        {
            if (stack_Remove.Count > 0)
                return (T)stack_Remove.Peek();
            else
                return _first_Entered_Data_In_Queue;
        }

        public T Dequeue()
        {
            if (stack_Add.Count > 0 && stack_Remove.Count == 0)
            {
                while (stack_Add.Count > 0)
                {
                    stack_Remove.Push(stack_Add.Pop());
                }
            }
            if (stack_Remove.Count > 0)
            {
                Count--;
                return (T)stack_Remove.Pop();
            }
            else
                return default(T);
        }
    }
}