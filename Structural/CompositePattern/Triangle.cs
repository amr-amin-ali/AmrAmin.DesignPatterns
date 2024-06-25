namespace AmrAmin.DesignPatterns.Structural.CompositePattern;

public class Triangle : IShape
{
    public void Render()
    {
        UiSkelton.WriteIndentedText2("Rendering a triangle.");
    }
}
