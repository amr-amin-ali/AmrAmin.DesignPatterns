namespace AmrAmin.DesignPatterns.Behavioral.ObserverPattern.PushCommunicationStyle;
/// <summary> Subject </summary> ///
public class Subject<T>
{
    private T _state;
    private readonly List<IObserver<T>> _observers = new List<IObserver<T>>();

    public void Attach(IObserver<T> observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver<T> observer)
    {
        _observers.Remove(observer);
    }

    public void SetState(T state)
    {
        _state = state;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_state);
        }
    }
}