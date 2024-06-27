namespace AmrAmin.DesignPatterns.Structural.FlyweightPattern;
public static class FlyweightExamples
{
    public static void RunExamples()
    {
        RunMapPointsExample();
    }
    private static void RunMapPointsExample()
    {
        UiSkelton.DrawHeader("Use FlyweightPattern to test the MAP POINTS example.");
        UiSkelton.WriteIndentedText1("Creating PointIconFactory.");
        var iconFactory = new PointIconFactory();
        UiSkelton.WriteIndentedText1("Creating PointService.");
        var pointService = new PointService(iconFactory);
        UiSkelton.WriteIndentedText1("Getting points from points service");
        var points = pointService.GetPoints();
        UiSkelton.WriteIndentedText1("Drawing all points");
        foreach (var point in points)
        {
            point.Draw();
        }

        UiSkelton.WriteIndentedText1("Notice that all the points created once.");

        UiSkelton.DrawFooter();

    }
}
