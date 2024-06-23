namespace AmrAmin.DesignPatterns.Behavioral.MediatorPattern.MediatorWithObserver;

// Observer interface
public interface IObserver
{
    void Update(string action, string data);
}
