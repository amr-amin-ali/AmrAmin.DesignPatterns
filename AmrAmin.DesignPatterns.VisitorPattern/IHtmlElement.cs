namespace AmrAmin.DesignPatterns.VisitorPattern;
// Element Interface
public interface IHtmlElement
{
    void Accept(IVisitor visitor);
}
