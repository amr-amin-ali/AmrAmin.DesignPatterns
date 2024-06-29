namespace AmrAmin.DesignPatterns.Structural.ProxyPattern.GangOfFour;
public class RealSubject : ISubject
{
    public void Request()
    {
        // Perform some expensive operation
        UiSkelton.WriteIndentedText3("RealSubject handling request.");
    }
}