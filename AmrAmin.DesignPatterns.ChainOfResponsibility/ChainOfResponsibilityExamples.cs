namespace AmrAmin.DesignPatterns.ChainOfResponsibility;
using AmrAmin.DesignPatterns.SharedKernel;

public static class ChainOfResponsibilityExamples
{
    public static void RunExamples()
    {
        RunWebServerExample();
    }
    private static void RunWebServerExample()
    {
        UiSkelton.DrawHeader("Use ChainOfResponsibilityPattern to test the WebServer example");
        var compressor = new Compressor(null!);
        var logger = new Logger(compressor);
        var authenticator = new Authenticator(logger);
        var webServer = new WebServer(authenticator);

        var request = new HttpRequest("AmrAmin", "123");
        webServer.Handle(request);

        UiSkelton.DrawFooter();

    }
}
