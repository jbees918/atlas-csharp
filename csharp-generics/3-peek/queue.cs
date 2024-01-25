using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
/// <typeparam name="T">The type of elements in queue.</typeparam>
public class Queue<T>
{
    /// <summary>
/// Peeks at value of first node in queue without removing it.
/// </summary>
/// <returns> Value of first node in queue.</returns>
    public T Peek()
{
    if (head == null)
    {
        Console.WriteLine("Queue is empty");
        return default(T);
    }
    return head.value;
}

    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary> Gets or sets the value of the node. </summary>
        public T value { get; set; }

        /// <summary> Gets or sets the next node in the queue. </summary>
        public Node next { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    private Node head, tail;
    private int count;

    /// <summary>
    /// Returns the Queue's type.
    /// </summary>
    /// <returns>The type of the Queue.</returns>
    public Type CheckType() => typeof(T);

    /// <summary>
    /// Enqueue Method.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
    /// <returns>The value that was enqueued.</returns>
    public T Enqueue(T value)
    {
        Node node = new Node(value);
        if (head == null)
            head = tail = node;
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
        return node.value;
    }

    /// <summary>
    /// Dequeue Method.
    /// </summary>
    /// <returns>The value that was dequeued.</returns>
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

    /// <summary>
    /// Counts Nodes in Queue.
    /// </summary>
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
