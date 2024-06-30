namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
public class PdfDocument
{
    private readonly List<string> _pages;

    public PdfDocument()
    {
        _pages = new List<string>();
    }

    public void AddPage(string page)
    {
        UiSkelton.WriteIndentedText5("Adding page to the PDF document");
        _pages.Add(page);
    }

    public void Export()
    {
        UiSkelton.WriteIndentedText5("Exporting the PDF document.");
    }
}