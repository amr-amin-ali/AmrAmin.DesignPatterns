namespace AmrAmin.DesignPatterns.Creational.PrototypePattern;
public class PowerPointPresentation
{
    private readonly List<IShape> _shapes = new List<IShape>();

    public void AddShape(IShape shape)
    {
        UiSkelton.WriteIndentedText2($"Powerpoint presentation is adding shape...");
        _shapes.Add(shape);
    }

    public void DuplicateShape(IShape shape)
    {
        UiSkelton.WriteIndentedText2($"Powerpoint presentation is cloning shape...");
        IShape clone = shape.Clone();
        UiSkelton.WriteIndentedText2($"Powerpoint presentation is adding the cloned shape...");
        _shapes.Add(clone);
    }

    public void DisplayAllShapes()
    {
        UiSkelton.WriteIndentedText2($"Powerpoint presentation is displaying all the shapes...");
        foreach (IShape shape in _shapes)
        {
            UiSkelton.WriteIndentedText3($"X:{shape.X}, Y:{shape.Y}, COLOR:{shape.Color}, WIDTH:{shape.Width}, HEIGHT:{shape.Height}");
        }
    }
}