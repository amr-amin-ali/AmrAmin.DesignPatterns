namespace AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;


public class MaterialButton : IButton
{
    public void Render()
    {
        UiSkelton.WriteIndentedText3($"Rendering {nameof(MaterialButton)}");
    }
}
