namespace AmrAmin.DesignPatterns.VisitorPattern;

public class TextElement : IHtmlElement
{
    private readonly string _content;

    public TextElement(string content)
    {
        _content = content;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitTextElement(this);
    }

    public override string ToString()
    {
        return _content;
    }
}
