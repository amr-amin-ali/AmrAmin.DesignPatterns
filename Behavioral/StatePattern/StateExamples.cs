namespace AmrAmin.DesignPatterns.Behavioral.StatePattern;

using AmrAmin.DesignPatterns;
using AmrAmin.DesignPatterns.Behavioral.StatePattern.PhotoshopExample;

public static class StateExamples
{
    public static void RunExamples()
    {
        RunPhotoshopExample();
    }

    private static void RunPhotoshopExample()
    {
        UiSkelton.DrawHeader("Use StatePattern to test the photoshop example");


        var canvas = new Canvas();
        canvas.SetTool(new SelectionTool());

        UiSkelton.WriteIndentedText1(string.Empty);
        canvas.MouseDown();

        UiSkelton.WriteIndentedText1(string.Empty);
        canvas.MouseUp();
        canvas.SetTool(new BrushTool());

        UiSkelton.WriteIndentedText1(string.Empty);
        canvas.MouseDown();

        UiSkelton.WriteIndentedText1(string.Empty);
        canvas.MouseUp();


        UiSkelton.DrawFooter();

    }
}
