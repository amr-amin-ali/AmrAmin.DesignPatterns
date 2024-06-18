namespace AmrAmin.DesignPatterns.IteratorPattern.BrowserExample;
public class ListIterator<T> : IIterator<T>
{
    private readonly BrowseHistory<T> _history;
    private int _currentIndex;

    public ListIterator(BrowseHistory<T> history)
    {
        this._history = history;
        this._currentIndex = 0;
    }

    public T Current()
    {
        return this._history.data[this._currentIndex];
    }

    public void Next()
    {
        this._currentIndex++;
    }

    public bool HasNext()
    {
        return this._currentIndex < this._history.data.Count;
    }
}