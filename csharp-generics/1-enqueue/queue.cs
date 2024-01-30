using System;

/// <summary> Queue class </summary>
public class Queue<T>
{
    class Node
    {
        public T value;
        public Node next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    Node head;
    Node tail;
    int count;

    /// <summary> Enqueue Method </summary>
    public T Enqueue(T value)
    {
        Node node = new Node(value);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
        return node.value;
    }

    /// <summary> Returns the Queue's type </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
