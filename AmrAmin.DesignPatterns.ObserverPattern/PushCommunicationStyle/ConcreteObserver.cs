namespace AmrAmin.DesignPatterns.ObserverPattern.PushCommunicationStyle;

using AmrAmin.DesignPatterns.SharedKernel;


/// <summary> Concrete Observer </summary>
public class ConcreteObserver<T> : IObserver<T>
{
    public void Update(T state)
    {
        // Observer receives the updated state from the subject
        UiSkelton.WriteIndentedText1(" ConcreteObserver gets updated: " + state);
        UiSkelton.DrawLineSeparator();
        // Do something with the updated state
    }
}