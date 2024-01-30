using System;

/// <summary> Queue class </summary>
public class Queue<T>
{
    // ...

    /// <summary> Concatenates all values in the queue only if the queue is of type String or Char </summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        Node node = head;
        string result = "";
        while (node != null)
        {
            result += node.value;
            if (typeof(T) == typeof(string) && node.next != null)
                result += " ";
            node = node.next;
        }
        return result;
    }
}
