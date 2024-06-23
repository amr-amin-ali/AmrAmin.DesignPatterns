namespace AmrAmin.DesignPatterns.Behavioral.IteratorPattern.BrowserExample;
public interface IIterator<T>
{
    T Current();
    void Next();
    bool HasNext();
}