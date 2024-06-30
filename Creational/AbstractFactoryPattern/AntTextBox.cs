namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;


// ConcreteProduct
public class AntTextBox : ITextBox
{
    public void Render()
    {
        UiSkelton.WriteIndentedText3($"Rendering {nameof(AntTextBox)}");
    }
}