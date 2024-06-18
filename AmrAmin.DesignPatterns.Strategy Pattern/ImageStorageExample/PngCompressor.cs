using AmrAmin.DesignPatterns.Strategy_Pattern.ImageStorageExample;

public class PngCompressor : ICompressor
{
    public void Compress(byte[] data)
    {
        Console.WriteLine("|         Compress using PNG.");
    }
}