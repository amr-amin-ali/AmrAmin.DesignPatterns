namespace AmrAmin.DesignPatterns.Behavioral.TemplateMethodPattern;
using System;

// ConcreteClass - Coffee
public class BrewCoffee : BrewingProcess
{
    protected override void Brew()
    {
        Console.WriteLine("|             Brewing coffee");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("|             Adding sugar and milk");
    }
}