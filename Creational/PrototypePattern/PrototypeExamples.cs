namespace AmrAmin.DesignPatterns.Creational.PrototypePattern;

using System.Drawing;

public static class PrototypeExamples
{
    public static void RunExamples()
    {
        DuplicateObjectExample();
    }
    private static void DuplicateObjectExample()
    {
        UiSkelton.DrawHeader("Use PrototypePattern to test the DuplicateObject example.");

        UiSkelton.WriteIndentedText1("Creating Power Point Presentation.");
        var powerPointPresentation = new PowerPointPresentation();
        UiSkelton.WriteIndentedText1($"Creating shape1 as (x: 1, y: 2, width: 10, height: 20, color: Color.Red) ");
        var shape1 = new Shape(x: 1, y: 2, width: 10, height: 20, color: Color.Red);
        UiSkelton.WriteIndentedText1($"Creating shape2 as (x: 9, y: 3, width: 12, height: 1, color: Color.Brown) ");
        var shape2 = new Shape(x: 9, y: 3, width: 12, height: 1, color: Color.Brown);
        UiSkelton.WriteIndentedText1("Adding shape1 to the presentation...");
        powerPointPresentation.AddShape(shape1);
        UiSkelton.WriteIndentedText1("Adding shape2 to the presentation...");
        powerPointPresentation.AddShape(shape2);
        UiSkelton.WriteIndentedText1("Duplicating shape 1...");
        powerPointPresentation.DuplicateShape(shape1);
        UiSkelton.WriteIndentedText1("Displaying all shapes within the presentation...");
        powerPointPresentation.DisplayAllShapes();

        UiSkelton.DrawFooter();
    }
}
