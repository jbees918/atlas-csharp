using System;

/// <summary> Queue class </summary>
public class Queue<T>
{
    int count;

    /// <summary> Returns Queue type </summary>
    public Type CheckType() => typeof(T);

    ///<summary> Count Nodes in the Queue </summary>
    public int Count()
    {
        int i = 0;
        Node node = head;
        while (node != null)
        {
            i++;
            node = node.next;
        }
        count = i;
        return count;
    }

    class Node
    {
        public T value;
        public Node next;

        public Node(T val)
        {
            value = val;
            next = null;
        }
    }

    Node head;
    Node tail;

    /// <summary> Dequeue Method </summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node node = head;
        head = node.next;
        count--;
        return node.value;
    }

    /// <summary> Enqueue Method </summary>
    public T Enqueue(T value)
    {
        Node node = new Node(value);
        if (head == null)
        {
            head = tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
        return node.value;
    }
}
