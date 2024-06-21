namespace AmrAmin.DesignPatterns;

using AmrAmin.DesignPatterns.ChainOfResponsibility;
using AmrAmin.DesignPatterns.CommandPattern;
using AmrAmin.DesignPatterns.IteratorPattern;
using AmrAmin.DesignPatterns.MediatorPattern;
using AmrAmin.DesignPatterns.MementoPattern;
using AmrAmin.DesignPatterns.ObserverPattern;
using AmrAmin.DesignPatterns.StatePattern;
using AmrAmin.DesignPatterns.Strategy_Pattern;
using AmrAmin.DesignPatterns.TemplateMethodPattern;

public class Program
{
    public static void Main(string[] args)
    {
        TemplateMethodExamples.RunExamples();
        IteratorExamples.RunExamples();
        StrategyExamples.RunExamples();
        MementoExamples.RunExamples();
        StateExamples.RunExamples();
        CommandPatternExamples.RunExamples();
        ObservableExamples.RunExamples();
        MediatorExamples.RunExamples();
        ChainOfResponsibilityExamples.RunExamples();
    }
}
