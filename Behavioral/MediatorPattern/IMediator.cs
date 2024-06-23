namespace AmrAmin.DesignPatterns.Behavioral.MediatorPattern;

// Mediator interface
public interface IMediator
{
    void Notify(object sender, string action);
}
