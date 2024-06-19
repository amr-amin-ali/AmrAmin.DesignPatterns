namespace AmrAmin.DesignPatterns.ObserverPattern.PushCommunicationStyle;


/// <summary> Subject </summary>
public class Subject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private int _state;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        // Subject pushes the updated state to the observers
        foreach (var observer in _observers)
        {
            observer.Update(_state);
        }
    }

    public void SetState(int state)
    {
        _state = state;
        NotifyObservers();
    }
}



