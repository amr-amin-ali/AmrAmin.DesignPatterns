namespace AmrAmin.DesignPatterns.Behavioral.IteratorPattern.BrowserExample;
using System.Collections.Generic;

public class BrowseHistory<T>
{
    public List<T> data = new List<T>();

    public void Push(T item)
    {
        data.Add(item);
    }

    public T Pop()
    {
        T item = data[data.Count - 1];
        data.RemoveAt(data.Count - 1);
        return item;
    }

    public IIterator<T> CreateIterator()
    {
        return new ListIterator<T>(this);
    }
}