namespace AmrAmin.DesignPatterns.ObserverPattern.PushCommunicationStyle;


/// <summary> Concrete Observer </summary>
public class ConcreteObserver : IObserver
{
    public void Update(int state)
    {
        // Observer receives the updated state from the subject
        // Do something with the updated state
    }
}