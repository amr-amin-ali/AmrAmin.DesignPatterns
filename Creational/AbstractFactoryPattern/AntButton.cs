namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;


public class AntButton : IButton
{
    public void Render()
    {
        UiSkelton.WriteIndentedText3($"Rendering {nameof(AntButton)}");
    }
}