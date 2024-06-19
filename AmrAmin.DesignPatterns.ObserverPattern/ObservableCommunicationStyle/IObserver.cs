namespace AmrAmin.DesignPatterns.ObserverPattern.ObservableCommunicationStyle;

public interface IObserver<T>
{
    void Update(T state);
}
