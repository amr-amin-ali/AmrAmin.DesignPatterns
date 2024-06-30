namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
public class Presentation
{
    private readonly List<Slide> _slides;

    public Presentation()
    {
        _slides = new List<Slide>();
    }

    public void AddSlide(Slide slide)
    {
        UiSkelton.WriteIndentedText5("Adding slide to the presentation");
        _slides.Add(slide);
    }

    public void ExportToPdf()
    {
        UiSkelton.WriteIndentedText5("Exporting presentation as PDF document.");
    }

    public void ExportToVideo()
    {
        UiSkelton.WriteIndentedText5("Exporting presentation as video.");

    }
}