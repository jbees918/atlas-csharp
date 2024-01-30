﻿using System;
/// <summary> Queue class </summary>
public class Queue<T>
{
    /// <summary>
    /// Represents an individual node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T value { get; set; }

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node next { get; set; }

        /// <summary>
        /// Initializes a new instance of the Node class with the specified value.
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
    /// Adds a new node with the specified value to the end of the queue.
    /// </summary>
    /// <param name="value">The value to be added to the queue.</param>
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
        }

        count++;
    }

    /// <summary>
    /// Returns the number of nodes in queue.
    /// </summary>
    /// <returns>The number of nodes in queue.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Remove first node in queue and return value.
    /// If queue empty print "Queue is empty" to console. return params type's default value.
    /// </summary>
    /// <returns>Dequeued node's value, or default value of parameter type only if queue is empty.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T dequeuedValue = head.value;
        head = head.next;

        if (head == null)
        {
            tail = null;
        }

        count--;

        return dequeuedValue;
    }
}