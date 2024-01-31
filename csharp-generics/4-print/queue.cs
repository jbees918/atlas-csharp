﻿using System;

class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count = 0;

    public int Count()
    {
        return count;
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (tail == null)
        {
            head = newNode;
            tail = newNode;
            count++;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
            count++;
        }
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T  value = head.value;

        head = head.next;
        count--;

        if (head == null)
        {
            tail = null;
        }

        return value;
    }

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        T  value = head.value;
        return value;
    }

    public Type CheckType()
    {
        return typeof(T);
    }

    public void Print()
    {
        Node temp = head;
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        while (temp != null)
        {
            Console.WriteLine(temp.value);
            temp = temp.next;
        }
    }

    public class Node
    {
        public T value { get; set; }
        public Node next { get; set; }

        public Node(T val)
        {
            value = val;
            next = null;
        }
    }
}