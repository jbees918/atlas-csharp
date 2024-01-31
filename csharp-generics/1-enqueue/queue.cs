﻿using System;

/// <summary> Queue class </summary>
public class Queue<T>
{

    class Node
    {
        public T value;
        public Node next;

        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
    }

    Node tail;
    Node head;
    
    int count;

    public Type CheckType()
    {
        return typeof(T);
    }

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

}