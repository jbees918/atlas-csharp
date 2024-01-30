using System;

/// <summary> Queue class </summary>
public class Queue<T>
{
    // ...

    /// <summary> Dequeue Method </summary>
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

    // ...
}
