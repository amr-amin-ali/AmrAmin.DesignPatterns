namespace AmrAmin.DesignPatterns.Behavioral.VisitorPattern;

// Concrete Elements
public class HtmlElement : IHtmlElement
{
    private readonly string _content;

    public HtmlElement(string content)
    {
        _content = content;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitHtmlElement(this);
    }

    public override string ToString()
    {
        return _content;
    }
}
