namespace AmrAmin.DesignPatterns.Behavioral.ObserverPattern.ObservableCommunicationStyle;

using AmrAmin.DesignPatterns;

/// <summary> Observer => the Concrete Observer </summary>
public class ConcreteObserver<T> : IObserver<T>
{
    private readonly string _name;

    public ConcreteObserver(string name)
    {
        _name = name;
    }

    public void Update(T state)
    {
        UiSkelton.WriteIndentedText1($"{_name} received update: {state}");
        UiSkelton.DrawLineSeparator();
    }
}


