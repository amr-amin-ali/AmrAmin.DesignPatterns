namespace AmrAmin.DesignPatterns.Strategy_Pattern.ImageStorageExample;
public class BlackAndWhiteFilter : IFilter
{
    public void Apply(byte[] data)
    {
        Console.WriteLine("|         Applying BLACK AND WHITE filter..");
    }
}