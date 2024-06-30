namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;


public class MaterialUIElementFactory : IUIElementFactory
{
    public ITextBox CreateTextBox()
    {
        return new MaterialTextBox();
    }

    public IButton CreateButton()
    {
        return new MaterialButton();
    }
}