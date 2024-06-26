namespace AmrAmin.DesignPatterns.Structural.DecoratorPattern;
/// <summary> Concrete Component </summary>
public class Stream : IStream
{
    public void Write(string data)
    {
        UiSkelton.WriteIndentedText2($"Writing data: {data}");
    }
}