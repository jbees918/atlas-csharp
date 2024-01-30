using System;

/// <summary> Queue class </summary>
public class Queue<T>
{
    // ...

    /// <summary> Peek Method </summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    // ...
}
