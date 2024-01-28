using System;

namespace YourNamespace
{
    public class Queue<T>
    {
        // Nested Node class
        public class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }

        // Properties
        public Node Head { get; private set; }
        public Node Tail { get; private set; }
        public int Count { get; private set; }

        // Enqueue method
        public void Enqueue(T item)
        {
            var newNode = new Node(item);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }

            Tail = newNode;
            Count++;
        }

        // Peek method
        public T Peek()
        {
            if (Head != null)
            {
                return Head.Value;
            }
            else
            {
                Console.WriteLine("Queue is empty");
                return default(T);
            }
        }

        // Count method
        public int Count()
        {
            return Count;
        }
    }
}
