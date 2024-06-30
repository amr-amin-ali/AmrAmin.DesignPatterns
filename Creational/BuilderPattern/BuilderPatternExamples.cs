namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
public static class BuilderPatternExamples
{
    public static void RunExamples()
    {
        ExportPowepointExample();
    }
    private static void ExportPowepointExample()
    {
        UiSkelton.DrawHeader("Use BuilderPattern to test the ExportPowepoint example.");
        //// Client
        //var presentationBuilder = new PresentationBuilder();
        //var iinterface = new Interface();
        //iinterface.Construct(presentationBuilder, "Slide 1", "The content");

        /////////////////////////////////////////////////////////////////
        ///
        UiSkelton.WriteIndentedText1("Create a presentation builder");
        var presentationBuilder2 = new PresentationBuilder();
        var interface2 = new Interface();
        interface2.Construct(presentationBuilder2, "Presentation Title", "Presentation Content");

        UiSkelton.DrawLineSeparator();

        UiSkelton.WriteIndentedText1("Create a PDF document builder");
        var pdfDocumentBuilder2 = new PdfDocumentBuilder();
        interface2.Construct(pdfDocumentBuilder2, "Pdf Title", "Pdf Content");

        UiSkelton.DrawLineSeparator();

        UiSkelton.WriteIndentedText1("Create a movie builder");
        var movieBuilder2 = new MovieBuilder();
        interface2.Construct(movieBuilder2, "Movie Title", "Movie Content");
        UiSkelton.DrawFooter();
    }
}
