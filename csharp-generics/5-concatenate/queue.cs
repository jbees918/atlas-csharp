using System;

/// <summary>
/// Represents a generic queue data structure.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    private class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T value;

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class with the specified value.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    private Node head;
    private Node tail;
    private int count;

    /// <summary>
    /// Gets the type of elements stored in the queue.
    /// </summary>
    /// <returns>The type of elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Enqueues a new element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
    /// <returns>The enqueued value.</returns>
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

    /// <summary>
    /// Dequeues an element from the front of the queue.
    /// </summary>
    /// <returns>The dequeued value.</returns>
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
    /// Retrieves the value at the front of the queue without removing it.
    /// </summary>
    /// <returns>The value at the front of the queue.</returns>
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
    /// Prints all elements in the queue.
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        Node node = head;
        while (node != null)
        {
            Console.WriteLine(node.value);
            node = node.next;
        }
    }

    /// <summary>
    /// Gets the count of elements in the queue.
    /// </summary>
    /// <returns>The count of elements in the queue.</returns>
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
