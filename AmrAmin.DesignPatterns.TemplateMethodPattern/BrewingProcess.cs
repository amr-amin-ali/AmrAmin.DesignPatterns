namespace AmrAmin.DesignPatterns.TemplateMethodPattern;
public abstract class BrewingProcess
{
    public void TemplateMethod()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    protected abstract void Brew();
    protected abstract void AddCondiments();

    private void BoilWater()
    {
        Console.WriteLine("|             Boiling water");
    }

    private void PourInCup()
    {
        Console.WriteLine("|             Pouring in cup");
    }
}
