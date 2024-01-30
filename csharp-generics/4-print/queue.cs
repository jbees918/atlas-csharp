using System;

/// <summary> Queue class. </summary>
public class Queue<T>
{
    // ...

    /// <summary> Print Method. </summary>
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

    // ...
}
