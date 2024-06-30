namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
public class PdfDocumentBuilder : IBuilder
{
    private readonly PdfDocument _pdfDocument;

    public PdfDocumentBuilder()
    {
        UiSkelton.WriteIndentedText2("Building a PDF document");
        _pdfDocument = new PdfDocument();
    }

    public void AddSlide(Slide slide)
    {
        UiSkelton.WriteIndentedText4("Adding slide as a page to the pdf document.");
        _pdfDocument.AddPage(slide.Content);
    }

    public void GetPdfDocument()
    {
        UiSkelton.WriteIndentedText4("Getting pdf document from the pdf document builder.");
        // Return the PDF document
    }

    public void GetMovie()
    {
        UiSkelton.WriteIndentedText4("Getting Movie from the pdf document builder");
        // Create movie from the PDF document
    }
}