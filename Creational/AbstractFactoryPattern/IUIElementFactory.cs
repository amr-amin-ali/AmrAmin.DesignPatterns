namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;
// AbstractFactory
public interface IUIElementFactory
{
    ITextBox CreateTextBox();
    IButton CreateButton();
}