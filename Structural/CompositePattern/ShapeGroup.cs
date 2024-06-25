namespace AmrAmin.DesignPatterns.Structural.CompositePattern;

// Composite
public class ShapeGroup : IShape
{
    private readonly List<IShape> _shapes = new List<IShape>();

    public void Add(IShape shape)
    {
        _shapes.Add(shape);
    }

    public void Remove(IShape shape)
    {
        _shapes.Remove(shape);
    }

    public void Render()
    {
        foreach (var shape in _shapes)
        {
            shape.Render();
        }
    }
}
