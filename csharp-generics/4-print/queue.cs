using System;

class CustomQueue<T>
{
    // ...

    public int GetCount()
    {
        return count;
    }

    public void AddItem(T value)
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

    public T RemoveItem()
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

    // ...

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
