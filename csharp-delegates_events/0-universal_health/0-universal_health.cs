/// <summary>
/// Simple queue class.
/// </summary>
public class Queue<T>
{
    // Items stored in queue
    private List<T> _items = new List<T>();

    /// <summary>
    /// Add item to end of queue.
    /// </summary>
    /// <param name="item">Item to add.</param>
    public void Enqueue(T item)
    {
        _items.Add(item);
    }

    /// <summary>
    /// Remove and return item from front of queue.
    /// </summary>
    /// <returns>Front item of queue.</returns>
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

    /// <summary>
    /// Return type of items in queue.
    /// </summary>
    /// <returns>Type of queue items.</returns>
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
