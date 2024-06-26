namespace AmrAmin.DesignPatterns.Structural.FacadePattern;

public class NotificationServer
{
    public void Send(string message, string target)
    {
        // Implement notification sending logic
        UiSkelton.WriteIndentedText3($"Sending message '{message}' to '{target}'");
    }
}