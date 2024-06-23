namespace AmrAmin.DesignPatterns.Behavioral.TemplateMethodPattern;
// ConcreteClass - Tea
public class BrewTea : BrewingProcess
{
    protected override void Brew()
    {
        Console.WriteLine("|             Brewing tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("|             Adding lemon");
    }
}
