namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;


// ConcreteFactory
public class AntUIElementFactory : IUIElementFactory
{
    public ITextBox CreateTextBox()
    {
        return new AntTextBox();
    }

    public IButton CreateButton()
    {
        return new AntButton();
    }
}