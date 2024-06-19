namespace AmrAmin.DesignPatterns.ObserverPattern.PullCommunicationStyle;

/// <summary> Subject </summary>
using System;
using System.Collections.Generic;

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

    public void SetState(T newState)
    {
        _state = newState;
        Notify();
    }

    public T GetState()
    {
        return _state;
    }

    private void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}
