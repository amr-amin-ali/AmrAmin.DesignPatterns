namespace AmrAmin.DesignPatterns.Behavioral.IteratorPattern.BrowserExample;
public class ListIterator<T> : IIterator<T>
{
    private readonly BrowseHistory<T> _history;
    private int _currentIndex;

    public ListIterator(BrowseHistory<T> history)
    {
        _history = history;
        _currentIndex = 0;
    }

    public T Current()
    {
        return _history.data[_currentIndex];
    }

    public void Next()
    {
        _currentIndex++;
    }

    public bool HasNext()
    {
        return _currentIndex < _history.data.Count;
    }
}