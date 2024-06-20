namespace AmrAmin.DesignPatterns.MediatorPattern.MediatorWithObserver;

using AmrAmin.DesignPatterns.SharedKernel;




// Concrete Observers
public class Navbar : IObserver
{
    private readonly UIMediator _mediator;
    private string _title;

    public Navbar(UIMediator mediator)
    {
        UiSkelton.WriteIndentedText1("Create Navbar UI component");
        _mediator = mediator;
        _mediator.Attach(this);
        _title = "Default Title";
        UiSkelton.WriteIndentedText2("Navbar title: " + _title);
    }

    public void UpdateTitle(string newTitle)
    {
        _title = newTitle;
        UiSkelton.WriteIndentedText3("Navbar title: " + newTitle);
        // Update the title in the Navbar
    }

    public void ResetTitle()
    {
        _title = "Default Title";
        UiSkelton.WriteIndentedText2("Navbar was resetted.");
        UiSkelton.WriteIndentedText3("Navbar title: " + _title);
        // Reset the title in the Navbar
    }

    public void Update(string action, string data)
    {
        if (action == "TextChanged")
        {
            // Update the navbar title
            UiSkelton.WriteIndentedText2("\"TextChanged\" so navbar title updated.");
            UpdateTitle(data);

        }
        else if (action == "Clicked")
        {
            // Reset the navbar title
            UiSkelton.WriteIndentedText2("\"ButtonClicked\" so navbar title resetted.");
            _title = "";

        }
    }
}