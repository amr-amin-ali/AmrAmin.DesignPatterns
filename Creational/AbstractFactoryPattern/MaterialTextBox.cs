namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;


public class MaterialTextBox : ITextBox
{
    public void Render()
    {
        UiSkelton.WriteIndentedText3($"Rendering {nameof(MaterialTextBox)}");
    }
}