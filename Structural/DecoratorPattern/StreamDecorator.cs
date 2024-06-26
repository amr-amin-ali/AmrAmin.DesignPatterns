namespace AmrAmin.DesignPatterns.Structural.DecoratorPattern;

/// <summary> Decorator base class  </summary>
public abstract class StreamDecorator : IStream
{
    protected IStream _stream;

    public StreamDecorator(IStream stream)
    {
        _stream = stream;
    }

    public virtual void Write(string data)
    {
        _stream.Write(data);
    }
}