namespace AmrAmin.DesignPatterns.Behavioral.VisitorPattern;
// Element Interface
public interface IHtmlElement
{
    void Accept(IVisitor visitor);
}
