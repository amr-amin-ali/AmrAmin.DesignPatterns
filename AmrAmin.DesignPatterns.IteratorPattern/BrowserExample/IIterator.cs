namespace AmrAmin.DesignPatterns.IteratorPattern.BrowserExample;
public interface IIterator<T>
{
    T Current();
    void Next();
    bool HasNext();
}