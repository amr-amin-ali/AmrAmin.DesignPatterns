namespace AmrAmin.DesignPatterns.Behavioral.VisitorPattern;

using System.Text.RegularExpressions;

using AmrAmin.DesignPatterns;

public class PlainTextVisitor : IVisitor
{
    public void VisitHtmlElement(HtmlElement element)
    {
        UiSkelton.WriteIndentedText2($"Converting HTML element to plain text: {RemoveHtmlTagsRegex(element.ToString())}");

    }

    public void VisitTextElement(TextElement element)
    {
        UiSkelton.WriteIndentedText2($"Displaying text element as plain text: {RemoveHtmlTagsRegex(element.ToString())}");
    }



    private static string RemoveHtmlTagsRegex(string html)
    {
        return Regex.Replace(html, "<.*?>", string.Empty);
    }
}
