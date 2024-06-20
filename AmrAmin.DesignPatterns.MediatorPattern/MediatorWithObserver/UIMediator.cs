namespace AmrAmin.DesignPatterns.MediatorPattern.MediatorWithObserver;

// Concrete Subject
public class UIMediator : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string action, string? data)
    {
        foreach (var observer in _observers)
        {
            observer.Update(action, data);
        }
    }

    public void TextBoxTextChanged(string newText)
    {
        Notify("TextChanged", newText);
    }

    public void ButtonClicked()
    {
        Notify("Clicked", null);
    }
}