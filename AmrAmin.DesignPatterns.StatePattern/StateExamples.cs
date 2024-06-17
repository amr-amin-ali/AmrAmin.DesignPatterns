namespace AmrAmin.DesignPatterns.StatePattern;
using AmrAmin.DesignPatterns.StatePattern.PhotoshopExample;

public static class StateExamples
{
    public static void RunPhotoshopExample()
    {
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine("|      Use StatePattern to test the photoshop example                               |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");
        Console.WriteLine("|                                                                                   |");
        var canvas = new Canvas();
        canvas.SetTool(new SelectionTool());
        Console.Write("|           ");
        canvas.MouseDown();
        Console.Write("|           ");
        canvas.MouseUp();
        canvas.SetTool(new BrushTool());
        Console.Write("|           ");
        canvas.MouseDown();
        Console.Write("|           ");
        canvas.MouseUp();
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/");

    }
}
