namespace AmrAmin.DesignPatterns.Strategy_Pattern.ImageStorageExample;
public class JpegCompressor : ICompressor
{
    public void Compress(byte[] data)
    {
        Console.WriteLine("|         Compress using JPEG.");
    }
}
