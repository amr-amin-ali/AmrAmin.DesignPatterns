namespace AmrAmin.DesignPatterns.Behavioral.StrategyPattern.ImageStorageExample;
public class JpegCompressor : ICompressor
{
    public void Compress(byte[] data)
    {
        Console.WriteLine("|         Compress using JPEG.");
    }
}
