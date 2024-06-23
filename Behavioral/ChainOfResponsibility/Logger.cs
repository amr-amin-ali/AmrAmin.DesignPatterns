namespace AmrAmin.DesignPatterns.Behavioral.ChainOfResponsibility;

using AmrAmin.DesignPatterns;

// Concrete Handlers
public class Logger : Handler
{
    public Logger(Handler next) : base(next)
    {
        UiSkelton.WriteIndentedText2($"{nameof(Logger)} instance was created.");
    }


    protected override bool DoHandle(HttpRequest request)
    {
        UiSkelton.WriteIndentedText2("Logger is logging.");
        if (request is null)
        {
            UiSkelton.WriteIndentedText3("Request was not logged.");
            return true;
        }
        UiSkelton.WriteIndentedText3("Request was logged successfully.");
        return false;
    }
}

