namespace AmrAmin.DesignPatterns.Structural.FlyweightPattern;

public class Point
{
    private readonly int _x;
    private readonly int _y;
    private readonly PointIcon _icon;

    public Point(int x, int y, PointIcon icon)
    {
        _x = x;
        _y = y;
        _icon = icon;
    }
    public void Draw()
    {
        UiSkelton.WriteIndentedText2($"Drawing X:{_x} Y:{_y} Type:{_icon.Type}");
    }
}