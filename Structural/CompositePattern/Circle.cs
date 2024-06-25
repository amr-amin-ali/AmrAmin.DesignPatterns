namespace AmrAmin.DesignPatterns.Structural.CompositePattern;


// Leaf
public class Circle : IShape
{
    public void Render()
    {
        UiSkelton.WriteIndentedText2("Rendering a circle.");
    }
}
