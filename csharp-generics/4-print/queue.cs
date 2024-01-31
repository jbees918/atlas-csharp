using System;

/// <summary> Generic queue </summary>
public class Queue<T>
{
    /// <summary> Node class </summary>
    class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }

        public Node(T val)
        {
            Value = val;
            Next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    public int Count => count;

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (tail == null)
        {
            head = tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T value = head.Value;
        head = head.Next;
        count--;

        if (head == null)
        {
            tail = null;
        }

        return value;
    }

    public T Peek() => head?.Value ?? default(T);

    public Type CheckType() => typeof(T);

    public void Print()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Value);
            temp = temp.Next;
        }
    }
}