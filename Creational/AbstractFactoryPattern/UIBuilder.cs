namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;


// Client
public class UIBuilder
{
    private readonly IUIElementFactory _uiElementFactory;

    public UIBuilder(IUIElementFactory uiElementFactory)
    {
        _uiElementFactory = uiElementFactory;
    }

    public void BuildUI()
    {
        UiSkelton.WriteIndentedText2("Creating UI elements using the UI element factory");
        var textBox = _uiElementFactory.CreateTextBox();
        var button = _uiElementFactory.CreateButton();

        UiSkelton.WriteIndentedText2("Rendering UI elements.");
        textBox.Render();
        button.Render();
    }
}