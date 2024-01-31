﻿using System;

public class Queue<T>
{
   
    public class Node
    {
      
        public T value { get; set; }

      
        public Node next { get; set; }

        
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    private Node tail;
    private Node head;
    private int count;

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

    public int Count()
    {
        return count;
    }

   
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