namespace AmrAmin.DesignPatterns;

using AmrAmin.DesignPatterns.IteratorPattern;
using AmrAmin.DesignPatterns.MementoPattern;
using AmrAmin.DesignPatterns.StatePattern;

public class Program
{
    public static void Main(string[] args)
    {
        IteratorExamples.RunBrowserExample();
        MementoExamples.RunEditorExample();
        MementoExamples.RunGangOfFourExample();
        StateExamples.RunPhotoshopExample();
    }
}
