namespace AmrAmin.DesignPatterns.ObserverPattern.ObservableCommunicationStyle;
// Subject
using System;
//using System.Collections.Generic;

public class Subject
{
    private readonly List<IObserver<int>> _observers;
    private int _state;

    public Subject()
    {
        _observers = new List<IObserver<int>>();
    }

    public void Subscribe(IObserver<int> observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver<int> observer)
    {
        _observers.Remove(observer);
    }

    public void SetState(int state)
    {
        _state = state;
        NotifyObservers();
    }

    private void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.OnNext(_state);
        }
    }
}

// Observer
public class ConcreteObserver : IObserver<int>
{
    public void OnNext(int value)
    {
        // Observer receives the updated state from the observable
        // Do something with the updated state
    }

    public void OnError(Exception error)
    {
        // Handle errors
    }

    public void OnCompleted()
    {
        // Handle completion
    }
}