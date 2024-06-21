namespace AmrAmin.DesignPatterns.ChainOfResponsibility;
// Handler abstract class
public abstract class Handler
{
    protected Handler next;

    public Handler(Handler next)
    {
        this.next = next;
    }

    public void Handle(HttpRequest request)
    {
        if (DoHandle(request))
        {
            return;
        }

        next?.Handle(request);
    }

    protected abstract bool DoHandle(HttpRequest request);
}
