namespace AmrAmin.DesignPatterns.Structural.FlyweightPattern;

public class PointIconFactory
{
    private readonly Dictionary<PointType, PointIcon> _icons = new Dictionary<PointType, PointIcon>();
    public PointIcon GetPointIcon(PointType type)
    {
        if (!_icons.ContainsKey(type))
        {
            UiSkelton.WriteIndentedText2($"PointIconFactory is generating new icon of type {type}");
            var icon = new PointIcon(type, null);
            _icons.Add(type, icon);
        }
        return _icons[type];
    }
}