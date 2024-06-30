namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
// Director
public class Interface
{
    public void Construct(IBuilder builder, string slideTitle, string slideContent)
    {
        UiSkelton.WriteIndentedText3("Constructing the interface");
        builder.AddSlide(new Slide(slideTitle, slideContent));
        builder.GetPdfDocument();
        builder.GetMovie();
    }
}
