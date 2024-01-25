using System;

/// <summary> Represents generic queue. </summary>
public class Queue<T>
{
    /// <summary> Represents node in a queue. </summary>
    public class Node
    {
        /// <summary> Gets or sets value of node. </summary>
        public T value { get; set; }

        /// <summary> Gets or sets next node in queue. </summary>
        public Node next { get; set; }

        /// <summary> Initializes new instance of the <see cref="Node"/> class. </summary>
        /// <param name="val">Value of node.</param>
        public Node(T val)
        {
            value = val;
            next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    /// <summary> Returns type of Queue. </summary>
    /// <returns>Type of Queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary> Adds new node to end of queue. </summary>
    /// <param name="value">Value of new node.</param>
    /// <returns>The value of new node.</returns>
    public T Enqueue(T value)
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
        }

        count++;
        return newNode.value;
    }

    /// <summary> Removes and returns value of the first node in the queue. </summary>
    /// <returns>The value of first node.</returns>
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

    /// <summary> Returns the number of nodes in the queue. </summary>
    /// <returns>The number of nodes in the queue.</returns>
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