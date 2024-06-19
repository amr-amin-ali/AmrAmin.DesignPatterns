namespace AmrAmin.DesignPatterns.StatePattern;

using AmrAmin.DesignPatterns.SharedKernel;
using AmrAmin.DesignPatterns.StatePattern.PhotoshopExample;

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

        UiSkelton.Indent1();
        canvas.MouseDown();

        UiSkelton.Indent1();
        canvas.MouseUp();
        canvas.SetTool(new BrushTool());

        UiSkelton.Indent1();
        canvas.MouseDown();

        UiSkelton.Indent1();
        canvas.MouseUp();


        UiSkelton.DrawFooter();

    }
}
