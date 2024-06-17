namespace AmrAmin.DesignPatterns.StatePattern.PhotoshopExample;
using System;

public class SelectionTool : ITool
{
    public void MouseUp()
    {
        Console.WriteLine("DASHED RECTANGLE was drawn as resoly of mouse up");
    }

    public void MouseDown()
    {
        Console.WriteLine("Mouse icon is now the SELECTION icon as result of mouse down");
    }
}
