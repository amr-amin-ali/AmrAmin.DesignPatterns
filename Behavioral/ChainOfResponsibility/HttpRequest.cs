namespace AmrAmin.DesignPatterns.Behavioral.ChainOfResponsibility;
public class HttpRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }

    public HttpRequest(string userName, string password)
    {
        UserName = userName;
        Password = password;
    }
}
