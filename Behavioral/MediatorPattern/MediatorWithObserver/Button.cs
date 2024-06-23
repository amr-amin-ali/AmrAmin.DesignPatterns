namespace AmrAmin.DesignPatterns.Behavioral.MediatorPattern.MediatorWithObserver;

using AmrAmin.DesignPatterns;




// Concrete Observers
public class Button : IObserver
{
    private readonly UIMediator _mediator;
    private bool _isEnabled;

    public Button(UIMediator mediator)
    {
        _mediator = mediator;
        _mediator.Attach(this);
        _isEnabled = false;
        UiSkelton.WriteIndentedText1("Create Button UI component");

    }

    public void Enable()
    {
        _isEnabled = true;
    }

    public void Disable()
    {
        _isEnabled = false;
    }

    public void Click()
    {
        if (_isEnabled)
        {
            _mediator.ButtonClicked();
        }
    }

    public void Update(string action, string data)
    {
        if (action == "Clicked")
        {
            UiSkelton.WriteIndentedText2("Button was clicked.");
            UiSkelton.WriteIndentedText3(" Clear textbox.");
            UiSkelton.WriteIndentedText3(" Clear listbox selection.");
            UiSkelton.WriteIndentedText3(" reset navbar title.");

            // Clear textbox, clear listbox selection, reset navbar title
            _mediator.ButtonClicked();
        }
    }
}