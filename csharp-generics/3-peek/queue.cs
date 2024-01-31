﻿using System;

/// <summary>
/// Generic Queue implementation.
/// </summary>
/// <typeparam name="T">Type of elements in the queue.</typeparam>
public class Queue<T>
{
    // Private Node class for internal use
    private class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T Value { get; }

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Initializes a new instance of the Node class with the specified value.
        /// </summary>
        /// <param name="val">The value of the node.</param>
        public Node(T val)
        {
            Value = val;
            Next = null;
        }
    }

    // Private fields
    private Node head = null;
    private Node tail = null;
    private int count = 0;

    /// <summary>
    /// Gets the number of nodes in the queue.
    /// </summary>
    public int Count => count;

    /// <summary>
    /// Adds a new element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
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

    /// <summary>
    /// Removes and returns the first element in the queue.
    /// </summary>
    /// <returns>The value of the dequeued element.</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default;
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

    /// <summary>
    /// Returns the value of the first element in the queue without removing it.
    /// </summary>
    /// <returns>The value of the first element.</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default;
        }

        return head.Value;
    }

    /// <summary>
    /// Returns the type of elements stored in the queue.
    /// </summary>
    /// <returns>The type of elements in the queue.</returns>
    public Type CheckType() => typeof(T);

    /// <summary>
    /// Prints all elements in the queue.
    /// </summary>
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
