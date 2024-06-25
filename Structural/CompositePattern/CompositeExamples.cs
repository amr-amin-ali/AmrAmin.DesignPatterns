namespace AmrAmin.DesignPatterns.Structural.CompositePattern;
public static class CompositeExamples
{
    public static void RunExamples()
    {
        RunShapesGroupingExample();
    }
    private static void RunShapesGroupingExample()
    {
        UiSkelton.DrawHeader("Use CompositePattern to test the SHAPES GRUOPING example.");
        // Usage
        var circle = new Circle();
        var square = new Square();
        var triangle = new Triangle();
        UiSkelton.WriteIndentedText1("Adding circle and square shapes to group 1.");
        var shapeGroup1 = new ShapeGroup();
        shapeGroup1.Add(circle);
        shapeGroup1.Add(square);

        UiSkelton.WriteIndentedText1("Adding triangle shape and group 1 to group 2.");
        var shapeGroup2 = new ShapeGroup();
        shapeGroup2.Add(triangle);
        shapeGroup2.Add(shapeGroup1);

        UiSkelton.WriteIndentedText1("Rendering group 2.");
        shapeGroup2.Render(); // Output: Rendering a triangle. Rendering a circle. Rendering a square.

        UiSkelton.DrawFooter();

    }
}
