namespace AmrAmin.DesignPatterns.Behavioral.ChainOfResponsibility;

using AmrAmin.DesignPatterns;

// Concrete Handlers
public class Authenticator : Handler
{
    public Authenticator(Handler next) : base(next)
    {
        UiSkelton.WriteIndentedText2($"{nameof(Authenticator)} instance was created.");
    }

    protected override bool DoHandle(HttpRequest request)
    {
        UiSkelton.WriteIndentedText2("Authenticator is authenticating user");
        if (request is null)
        {
            UiSkelton.WriteIndentedText3("User was not authenticated.");
            return false;
        }
        if (request.UserName == "AmrAmin" && request.Password == "123")
        {
            UiSkelton.WriteIndentedText3("User authenticated successfully.");
            return false;
        }
        UiSkelton.WriteIndentedText3("User was not authenticated++.");
        return true;
    }
}
