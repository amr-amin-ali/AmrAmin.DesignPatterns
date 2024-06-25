namespace AmrAmin.DesignPatterns.Structural.CompositePattern;

public class Square : IShape
{
    public void Render()
    {
        UiSkelton.WriteIndentedText2("Rendering a square.");
    }
}
