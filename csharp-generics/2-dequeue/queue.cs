using System;

/// <summary> Queue class </summary>
public class Queue<T>
{
    // ...

    /// <summary> Removes the first element from the Queue and returns its value </summary>
    public T Dequeue()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        var temp = Head;
        Head = Head.Next;
        Count--;

        if (Head == null)
        {
            Tail = null;
        }

        return temp.Value;
    }
}
