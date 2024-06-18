namespace AmrAmin.DesignPatterns;

using AmrAmin.DesignPatterns.IteratorPattern;
using AmrAmin.DesignPatterns.MementoPattern;
using AmrAmin.DesignPatterns.StatePattern;
using AmrAmin.DesignPatterns.Strategy_Pattern;
using AmrAmin.DesignPatterns.TemplateMethodPattern;

public class Program
{
    public static void Main(string[] args)
    {
        TemplateMethodExamples.RunBrewingProcessExample();
        StrategyExamples.RunGangOfFourExample();
        StrategyExamples.RunImageStorageExample();
        IteratorExamples.RunBrowserExample();
        MementoExamples.RunEditorExample();
        MementoExamples.RunGangOfFourExample();
        StateExamples.RunPhotoshopExample();
    }
}
