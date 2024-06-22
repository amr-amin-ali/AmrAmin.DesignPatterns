namespace AmrAmin.DesignPatterns.VisitorPattern;

// Visitor Interface
public interface IVisitor
{
    void VisitHtmlElement(HtmlElement element);
    void VisitTextElement(TextElement element);
}
