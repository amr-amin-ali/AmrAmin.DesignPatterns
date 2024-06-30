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
using AmrAmin.DesignPatterns.Creational.AbstractFactoryPattern;
using AmrAmin.DesignPatterns.Creational.BuilderPattern;
using AmrAmin.DesignPatterns.Creational.FactoryMethodPattern;
using AmrAmin.DesignPatterns.Creational.PrototypePattern;
using AmrAmin.DesignPatterns.Creational.SingletonPattern;
using AmrAmin.DesignPatterns.Structural.AdapterPattern;
using AmrAmin.DesignPatterns.Structural.BridgePattern;
using AmrAmin.DesignPatterns.Structural.CompositePattern;
using AmrAmin.DesignPatterns.Structural.DecoratorPattern;
using AmrAmin.DesignPatterns.Structural.FacadePattern;
using AmrAmin.DesignPatterns.Structural.FlyweightPattern;
using AmrAmin.DesignPatterns.Structural.ProxyPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(@"
        /************************************************************\
        |                                                            |
        |      Behavioral design patterns examples                   |
        |                                                            |
        \************************************************************/
");
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
        Console.WriteLine(@"
        /************************************************************\
        |                                                            |
        |      Structural design patterns examples                   |
        |                                                            |
        \************************************************************/
        ");
        CompositeExamples.RunExamples();
        AdapterExamples.RunExamples();
        DecoratorExamples.RunExamples();
        FacadeExamples.RunExamples();
        FlyweightExamples.RunExamples();
        BridgeExamples.RunExamples();
        ProxyExamples.RunExamples();
        Console.WriteLine(@"
        /************************************************************\
        |                                                            |
        |      Creational design patterns examples                   |
        |                                                            |
        \************************************************************/
        ");
        SingletonExamples.RunExamples();
        PrototypeExamples.RunExamples();
        FactoryMethodExamples.RunExamples();
        BuilderPatternExamples.RunExamples();
        AbstractFactoryExamples.RunExamples();
    }
}
