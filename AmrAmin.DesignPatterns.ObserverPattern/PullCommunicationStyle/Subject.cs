namespace AmrAmin.DesignPatterns.ObserverPattern.PullCommunicationStyle;

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
        // No state update is pushed to the observers
    }

    public int GetState()
    {
        return _state;
    }

    public void SetState(int state)
    {
        _state = state;
        NotifyObservers();
    }
}