namespace AmrAmin.DesignPatterns.Strategy_Pattern.ImageStorageExample;
public class HighContrastFilter : IFilter
{
    public void Apply(byte[] data)
    {
        Console.WriteLine("|         Applying HIGH CONTRAST filter..");
    }
}
