namespace AmrAmin.DesignPatterns.ObserverPattern.ObservableCommunicationStyle;

using AmrAmin.DesignPatterns.SharedKernel;

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
        UiSkelton.Indent1();
        Console.WriteLine($"{_name} received update: {state}");
        UiSkelton.DrawLineSeparator();
    }
}


