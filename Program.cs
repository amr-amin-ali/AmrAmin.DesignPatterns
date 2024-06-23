namespace AmrAmin.DesignPatterns;

using AmrAmin.DesignPatterns.Behavioral.ChainOfResponsibility;
using AmrAmin.DesignPatterns.Behavioral.CommandPattern;
using AmrAmin.DesignPatterns.Behavioral.IteratorPattern;
using AmrAmin.DesignPatterns.Behavioral.MediatorPattern;
using AmrAmin.DesignPatterns.Behavioral.MementoPattern;
using AmrAmin.DesignPatterns.Behavioral.ObserverPattern;
using AmrAmin.DesignPatterns.Behavioral.StatePattern;
using AmrAmin.DesignPatterns.Behavioral.StrategyPattern;
using AmrAmin.DesignPatterns.Behavioral.TemplateMethodPattern;
using AmrAmin.DesignPatterns.Behavioral.VisitorPattern;

public class Program
{
    public static void Main(string[] args)
    {
        IteratorExamples.RunExamples();
        MementoExamples.RunExamples();
        StateExamples.RunExamples();
        CommandPatternExamples.RunExamples();
        ObservableExamples.RunExamples();
        MediatorExamples.RunExamples();
        VisitorExamples.RunExamples();
        ChainOfResponsibilityExamples.RunExamples();
        TemplateMethodExamples.RunExamples();
        StrategyExamples.RunExamples();
    }
}
