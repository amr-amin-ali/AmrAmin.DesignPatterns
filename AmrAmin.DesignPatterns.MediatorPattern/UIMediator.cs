namespace AmrAmin.DesignPatterns.MediatorPattern;

using AmrAmin.DesignPatterns.SharedKernel;

// Concrete Mediator
public class UIMediator : IMediator
{
    private TextBox _textBox;
    private Button _button;
    private ListBox _listBox;
    private Navbar _navbar;

    public void RegisterTextBox(TextBox textBox)
    {
        _textBox = textBox;
    }

    public void RegisterButton(Button button)
    {
        _button = button;
    }

    public void RegisterListBox(ListBox listBox)
    {
        _listBox = listBox;
    }

    public void RegisterNavbar(Navbar navbar)
    {
        _navbar = navbar;
    }

    public void Notify(object sender, string action)
    {
        if (sender == _textBox && action == "TextChanged")
        {
            UiSkelton.WriteIndentedText2("TextBox notification was fired.");

            _button.Enable();
            _listBox.FilterItems(_textBox.Text);
            _navbar.UpdateTitle(_textBox.Text);
        }
        else if (sender == _button && action == "Clicked")
        {
            UiSkelton.WriteIndentedText2("Button notification was fired.");

            _textBox.Clear();
            _listBox.ClearSelection();
            _navbar.ResetTitle();
        }
    }
}
