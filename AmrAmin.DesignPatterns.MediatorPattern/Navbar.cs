namespace AmrAmin.DesignPatterns.MediatorPattern;

using AmrAmin.DesignPatterns.SharedKernel;

public class Navbar
{
    private readonly IMediator _mediator;
    private string _title;

    public Navbar(IMediator mediator)
    {
        _mediator = mediator;
        _title = "Default Title";
    }

    public void UpdateTitle(string newTitle)
    {
        _title = newTitle;
        UiSkelton.WriteIndentedText2("Navbar title was updated.");

    }

    public void ResetTitle()
    {
        _title = "Default Title";
        UiSkelton.WriteIndentedText2("Navbar title was resetted.");
    }
}