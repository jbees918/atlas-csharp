// Define a simple queue class
public class Queue<T>
{
    // Store items in queue
    private List<T> _items = new List<T>();

    // Add item to end of queue
    public void Enqueue(T item)
    {
        _items.Add(item);
    }

    // Remove and return item from front of queue
    public T Dequeue()
    {
        if (_items.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        T item = _items[0];
        _items.RemoveAt(0);

        return item;
    }

    // Return type of items in queue
    public Type CheckType()
    {
        if (_items.Count > 0)
        {
            return _items[0].GetType();
        }
        else
        {
            return typeof(T);
        }
    }
}
