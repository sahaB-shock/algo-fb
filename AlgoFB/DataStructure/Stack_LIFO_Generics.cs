namespace AlgoFB.DataStructure
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(object x)
        {
            Data = (T)x;
        }
    }

    public class Stack_LIFO_Generics<T>
    {
        private Node<T> _lastNode = null;

        public int Count { get; private set; } = 0;

        public T Peek()
        {
            if (_lastNode == null)
                return default(T);
            else
                return (T)_lastNode.Data;
        }

        //5 → 6 → 1
        //lastNode
        public void Push(T data)
        {
            Node<T> newLastNode = new Node<T>(data);
            if (_lastNode == null)
            {
                _lastNode = newLastNode;
            }
            else
            {
                newLastNode.Next = _lastNode;
            }
            _lastNode = newLastNode;

            Count++;
        }

        public T Pop()
        {
            if (_lastNode == null)
                return default(T);

            var tmpLastNodeValue = _lastNode.Data;
            _lastNode = _lastNode.Next;
            Count--;
            return tmpLastNodeValue;
        }
    }
}