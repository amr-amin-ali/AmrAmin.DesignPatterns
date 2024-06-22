namespace AmrAmin.DesignPatterns.VisitorPattern;

using AmrAmin.DesignPatterns.SharedKernel;

// Concrete Visitors
public class HighlightVisitor : IVisitor
{
    public void VisitHtmlElement(HtmlElement element)
    {
        UiSkelton.WriteIndentedText2($"Highlighting HTML element: {MarkHtmlElement(element.ToString())}");
    }

    public void VisitTextElement(TextElement element)
    {
        UiSkelton.WriteIndentedText2($"Highlighting text element: {MarkHtmlElement(element.ToString())}");
    }

    private static string MarkHtmlElement(string htmlElement)
    {
        return $"<mark>{htmlElement}</mark>";
    }
}
