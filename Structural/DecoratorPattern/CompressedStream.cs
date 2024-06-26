namespace AmrAmin.DesignPatterns.Structural.DecoratorPattern;

/// <summary> Concrete Decorator </summary>
public class CompressedStream : StreamDecorator
{
    public CompressedStream(IStream stream) : base(stream) { }

    public override void Write(string data)
    {
        string compressedData = Compress(data);
        base.Write(compressedData);
    }

    private string Compress(string data)
    {
        // Implement compression logic
        Random random = new Random();
        var randomStartIndex = random.Next(1, data.Length / 2);
        var randomlength = random.Next(1, data.Length / 2);
        return data.Substring(randomStartIndex, randomlength);
        ;
    }
}