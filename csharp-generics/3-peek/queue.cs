// Peek method.
public T Peek()
{
    if (Head != null)
    {
        return Head.Value;
    }
    else
    {
        Console.WriteLine("Queue is empty");
        return default(T);
    }
}
