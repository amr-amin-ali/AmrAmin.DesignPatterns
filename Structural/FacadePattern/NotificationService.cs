namespace AmrAmin.DesignPatterns.Structural.FacadePattern;

// Facade class
public class NotificationService
{
    private readonly NotificationServer _notificationServer;
    private readonly AuthToken _authToken;
    private readonly Connection _connection;

    public NotificationService()
    {
        _notificationServer = new NotificationServer();
        _authToken = new AuthToken();
        _connection = new Connection();
        _connection.Connect();
    }

    public void Send(string message, string target)
    {
        var token = _authToken.GetToken();
        _notificationServer.Send(message, target);
    }
}