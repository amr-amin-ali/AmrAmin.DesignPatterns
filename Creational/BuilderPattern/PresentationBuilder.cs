namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
// ConcreteBuilder
public class PresentationBuilder : IBuilder
{
    private readonly Presentation _presentation;

    public PresentationBuilder()
    {
        UiSkelton.WriteIndentedText2("Building a Presentation");

        _presentation = new Presentation();
    }

    public void AddSlide(Slide slide)
    {
        UiSkelton.WriteIndentedText4("Adding slide to the presentation");
        _presentation.AddSlide(slide);
    }

    public void GetPdfDocument()
    {
        UiSkelton.WriteIndentedText4("Getting pdf document from the presentation builder");
        // Create PDF document from the presentation
    }

    public void GetMovie()
    {
        UiSkelton.WriteIndentedText4("Getting a movie from the presentation builder");
        // Create movie from the presentation
    }
}