namespace AmrAmin.DesignPatterns.ObserverPattern.PushCommunicationStyle;

/// <summary> Observer </summary>
public interface IObserver<T>
{
    void Update(T state);
}

