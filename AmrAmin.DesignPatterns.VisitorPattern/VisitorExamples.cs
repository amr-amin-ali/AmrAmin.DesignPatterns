namespace AmrAmin.DesignPatterns.VisitorPattern;

using AmrAmin.DesignPatterns.SharedKernel;

public static class VisitorExamples
{
    public static void RunExamples()
    {
        RunHtmlExample();
    }
    private static void RunHtmlExample()
    {
        UiSkelton.DrawHeader("Use VisitorPattern to test the Html example");

        // Usage Example
        var htmlElement = new HtmlElement("<h1>Hello, World!</h1>");
        var textElement = new TextElement("This is some plain text.");

        var highlightVisitor = new HighlightVisitor();
        var plainTextVisitor = new PlainTextVisitor();

        UiSkelton.WriteIndentedText1($"Apply the {nameof(HighlightVisitor)} on {nameof(HtmlElement)}.");
        htmlElement.Accept(highlightVisitor);
        UiSkelton.WriteIndentedText1($"Apply the {nameof(PlainTextVisitor)} on {nameof(HtmlElement)}.");
        htmlElement.Accept(plainTextVisitor);

        UiSkelton.WriteIndentedText1($"Apply the {nameof(HighlightVisitor)} on {nameof(TextElement)}.");
        textElement.Accept(highlightVisitor);
        UiSkelton.WriteIndentedText1($"Apply the {nameof(PlainTextVisitor)} on {nameof(TextElement)}.");
        textElement.Accept(plainTextVisitor);


        UiSkelton.DrawFooter();

    }
}
