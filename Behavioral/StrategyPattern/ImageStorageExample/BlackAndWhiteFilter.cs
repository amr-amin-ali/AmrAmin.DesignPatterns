namespace AmrAmin.DesignPatterns.Behavioral.StrategyPattern.ImageStorageExample;
public class BlackAndWhiteFilter : IFilter
{
    public void Apply(byte[] data)
    {
        Console.WriteLine("|         Applying BLACK AND WHITE filter..");
    }
}