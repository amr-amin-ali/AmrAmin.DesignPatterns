namespace AmrAmin.DesignPatterns.Structural.FacadePattern;
public static class FacadeExamples
{
    public static void RunExamples()
    {
        RunNotificationServiceExample();
    }
    private static void RunNotificationServiceExample()
    {
        UiSkelton.DrawHeader("Use FacadePattern to test the NotificationService example.");

        UiSkelton.WriteIndentedText1("Before using NotificationService facade.");
        UiSkelton.WriteIndentedText2("Creating message");
        var message = new Message { Content = "Hello, world!" };
        UiSkelton.WriteIndentedText2("Creating notification server");
        var notificationServer = new NotificationServer();
        UiSkelton.WriteIndentedText2("Creating auth token");
        var authToken = new AuthToken();
        UiSkelton.WriteIndentedText2("Creating connection");
        var connection = new Connection();

        UiSkelton.WriteIndentedText2("Connecting...");
        connection.Connect();
        UiSkelton.WriteIndentedText2("Getting token");
        var token = authToken.GetToken();
        UiSkelton.WriteIndentedText2("Sending message");
        notificationServer.Send(message.Content, "user@example.com");
        UiSkelton.WriteIndentedText2("Message sent.");


        UiSkelton.DrawLineSeparator();
        UiSkelton.DrawLineSeparator();
        UiSkelton.DrawLineSeparator();





        UiSkelton.WriteIndentedText1("After using NotificationService facade.");
        UiSkelton.WriteIndentedText2("Creating notification serveice");
        var notificationService = new NotificationService();
        UiSkelton.WriteIndentedText2("Sending message");
        notificationService.Send("Hello, world!", "user@example.com");
        UiSkelton.WriteIndentedText2("Message sent.");



        UiSkelton.DrawFooter();

    }
}
