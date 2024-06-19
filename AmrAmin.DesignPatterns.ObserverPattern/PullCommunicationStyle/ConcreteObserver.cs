namespace AmrAmin.DesignPatterns.ObserverPattern.PullCommunicationStyle;

/// <summary> Concrete Observer </summary>
public class ConcreteObserver : IObserver
{
    public void Update(Subject subject)
    {
        // Observer pulls the updated state from the subject
        int state = subject.GetState();
        // Do something with the updated state
    }
}