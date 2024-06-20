namespace AmrAmin.DesignPatterns.MediatorPattern;

// Concrete Components
public class TextBox
{
    private readonly IMediator _mediator;
    public string Text { get; set; }

    public TextBox(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void TextChanged()
    {
        _mediator.Notify(this, "TextChanged");
    }
    public void Clear()
    {
        Text = string.Empty;
        _mediator.Notify(this, "Text Cleared");
    }
}

