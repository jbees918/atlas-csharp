using System;

/// <summary> Queue class </summary>
public class Queue<T>
{
    /// <summary> Node class </summary>
    public class Node
    {
        /// <summary> Value </summary>
        public T value;
        /// <summary> Next Node </summary>
        public Node next;

        /// <summary> Node Constructor </summary>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    /// <summary> Head Node </summary>
    public Node head;
    /// <summary> Tail Node </summary>
    public Node tail;
    /// <summary> Count </summary>
    public int count;

    /// <summary> Checks Type of Method </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> Enqueue Method </summary>
    public void Enqueue(T value)
    {
        var newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary> Count Method </summary>
    public int Count()
    {
        return count;
    }
}
