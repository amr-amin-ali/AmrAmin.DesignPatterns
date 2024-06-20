namespace AmrAmin.DesignPatterns.MediatorPattern.MediatorWithObserver;

using AmrAmin.DesignPatterns.SharedKernel;




// Concrete Observers
public class TextBox : IObserver
{
    private readonly UIMediator _mediator;
    public string Text { get; set; }

    public TextBox(UIMediator mediator)
    {
        UiSkelton.WriteIndentedText1("Create TextBox UI component");
        _mediator = mediator;
        _mediator.Attach(this);
    }

    public void TextChanged()
    {
        _mediator.TextBoxTextChanged(Text);
    }

    public void Update(string action, string data)
    {
        if (action == "TextChanged")
        {
            // Enable button, filter listbox, update navbar title
        }
    }
}