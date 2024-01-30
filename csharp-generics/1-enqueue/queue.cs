using System;

/// <summary> class Queue </summary>
public class Queue<T>
{
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
    int count;

    /// <summary> Return Queue type </summary>
    public Type CheckType() => typeof(T);

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
}
