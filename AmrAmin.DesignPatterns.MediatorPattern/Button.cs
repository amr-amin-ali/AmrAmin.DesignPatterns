namespace AmrAmin.DesignPatterns.MediatorPattern;

using AmrAmin.DesignPatterns.SharedKernel;

public class Button
{
    private readonly IMediator _mediator;
    private bool _isEnabled;

    public Button(IMediator mediator)
    {
        _mediator = mediator;
        _isEnabled = false;
    }

    public void Enable()
    {
        _isEnabled = true;
        UiSkelton.WriteIndentedText2("Button is enabled.");
    }

    public void Disable()
    {
        _isEnabled = false;
        UiSkelton.WriteIndentedText2("Button is disabled.");

    }

    public void Click()
    {
        if (_isEnabled)
        {
            _mediator.Notify(this, "Clicked");
        }
    }
}
