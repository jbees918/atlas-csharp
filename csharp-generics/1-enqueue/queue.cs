using System;

public class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count = 0;

    public int Count()
    {
        return count;
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
            count++;
        }
    }

    public Type CheckType()
    {
        return typeof(T);
    }

    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }

        public Node(T val)
        {
            value = val;
            next = null;
        }
    }
}
