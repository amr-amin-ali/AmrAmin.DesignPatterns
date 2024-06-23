using AmrAmin.DesignPatterns.Behavioral.StrategyPattern.ImageStorageExample;

public class PngCompressor : ICompressor
{
    public void Compress(byte[] data)
    {
        Console.WriteLine("|         Compress using PNG.");
    }
}