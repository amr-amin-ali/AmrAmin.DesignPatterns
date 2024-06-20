namespace AmrAmin.DesignPatterns.MediatorPattern;

// Mediator interface
public interface IMediator
{
    void Notify(object sender, string action);
}
