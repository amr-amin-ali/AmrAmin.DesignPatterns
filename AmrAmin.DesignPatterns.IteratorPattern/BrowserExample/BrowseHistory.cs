namespace AmrAmin.DesignPatterns.IteratorPattern.BrowserExample;
using System.Collections.Generic;
public class BrowseHistory<T>
{
    public List<T> data = new List<T>();

    public void Push(T item)
    {
        this.data.Add(item);
    }

    public T Pop()
    {
        T item = this.data[this.data.Count - 1];
        this.data.RemoveAt(this.data.Count - 1);
        return item;
    }

    public IIterator<T> CreateIterator()
    {
        return new ListIterator<T>(this);
    }
}