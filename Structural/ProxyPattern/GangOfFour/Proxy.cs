namespace AmrAmin.DesignPatterns.Structural.ProxyPattern.GangOfFour;
public class Proxy : ISubject
{
    private RealSubject _realSubject;

    public void Request()
    {
        // Optional: Perform additional operations before forwarding the request
        UiSkelton.WriteIndentedText2("Proxy is creating RealSubject.");
        _realSubject ??= new RealSubject();
        UiSkelton.WriteIndentedText2("Proxy is calling the real subject request method...");
        _realSubject.Request();
        // Optional: Perform additional operations after the request
    }
}