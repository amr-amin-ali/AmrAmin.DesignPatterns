namespace AmrAmin.DesignPatterns.ChainOfResponsibility;

using AmrAmin.DesignPatterns.SharedKernel;

// Concrete Handlers
public class Compressor : Handler
{
    public Compressor(Handler next) : base(next)
    {
        UiSkelton.WriteIndentedText2($"{nameof(Compressor)} instance was created.");
    }

    protected override bool DoHandle(HttpRequest request)
    {
        UiSkelton.WriteIndentedText2("Compressor is compressing request");
        if (request is null)
        {
            UiSkelton.WriteIndentedText3("Request was not compressed.");
            return true;
        }
        UiSkelton.WriteIndentedText3("Request was compressed.");
        return false;
    }
}
