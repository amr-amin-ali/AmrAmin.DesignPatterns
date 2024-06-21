namespace AmrAmin.DesignPatterns.ChainOfResponsibility;

using AmrAmin.DesignPatterns.SharedKernel;

// WebServer class
public class WebServer
{
    private readonly Handler _handler;

    public WebServer(Handler handler)
    {
        _handler = handler;
        UiSkelton.WriteIndentedText2("WebServer started...");
    }

    public void Handle(HttpRequest request)
    {
        UiSkelton.WriteIndentedText2("WebServer started handling request...");
        _handler.Handle(request);
    }
}
