namespace AmrAmin.DesignPatterns.Structural.FlyweightPattern;
public class PointService
{
    private PointIconFactory IconFactory { get; set; }

    public PointService(PointIconFactory iconFactory)
    {
        IconFactory = iconFactory;
    }
    public List<Point> GetPoints()
    {
        return [
            new Point(x: 1, y: 7, icon: IconFactory.GetPointIcon(PointType.CAFE)),
            new Point(x: 2, y: 8, icon: IconFactory.GetPointIcon(PointType.HOSPITAL)),
            new Point(x: 3, y: 9, icon: IconFactory.GetPointIcon(PointType.RESTAURANT)),
            new Point(x: 4, y: 10, icon: IconFactory.GetPointIcon(PointType.CAFE)),
            new Point(x: 5, y: 11, icon: IconFactory.GetPointIcon(PointType.HOSPITAL)),
            new Point(x: 6, y: 12, icon: IconFactory.GetPointIcon(PointType.RESTAURANT)),
            ];
    }
}
