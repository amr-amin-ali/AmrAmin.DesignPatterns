namespace AmrAmin.DesignPatterns.Behavioral.StatePattern.PhotoshopExample;
using System;

public class BrushTool : ITool
{
    public void MouseUp()
    {
        Console.WriteLine("LINE was drawn as resoly of mouse up");
    }

    public void MouseDown()
    {
        Console.WriteLine("Mouse icon is now the BRUSH icon as result of mouse down");
    }
}
