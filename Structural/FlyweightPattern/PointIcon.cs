namespace AmrAmin.DesignPatterns.Structural.FlyweightPattern;

public class PointIcon
{
    public readonly PointType Type;
    private readonly byte[] _icon;

    public PointIcon(PointType type, byte[] icon)
    {
        _icon = icon;
        Type = type;
    }
}