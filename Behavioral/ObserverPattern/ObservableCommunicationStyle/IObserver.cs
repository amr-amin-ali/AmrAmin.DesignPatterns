namespace AmrAmin.DesignPatterns.Behavioral.ObserverPattern.ObservableCommunicationStyle;

public interface IObserver<T>
{
    void Update(T state);
}
