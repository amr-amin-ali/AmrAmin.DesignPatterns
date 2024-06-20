namespace AmrAmin.DesignPatterns.ObserverPattern.PullCommunicationStyle;

using AmrAmin.DesignPatterns.SharedKernel;

/// <summary> Concrete Observer </summary>
public class ConcreteObserver<T> : IObserver<T>
{
    private readonly string _name;
    private readonly Subject<T> _subject;

    public ConcreteObserver(string name, Subject<T> subject)
    {
        _name = name;
        _subject = subject;
    }

    public void Update()
    {
        T state = _subject.GetState();
        UiSkelton.WriteIndentedText1($"{_name} received update: {state}");
        UiSkelton.DrawLineSeparator();
    }
}
