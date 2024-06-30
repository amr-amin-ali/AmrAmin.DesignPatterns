namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
public class MovieBuilder : IBuilder
{
    private readonly Movie _movie;

    public MovieBuilder()
    {
        UiSkelton.WriteIndentedText2("Building a MOVIE");
        _movie = new Movie();
    }

    public void AddSlide(Slide slide)
    {
        UiSkelton.WriteIndentedText4("Adding slide as video clip to the movie");
        _movie.AddVideoClip(slide.Content);
    }

    public void GetPdfDocument()
    {
        UiSkelton.WriteIndentedText4("Adding slide as pdf document to the movie ");
        // Create PDF document from the movie
    }

    public void GetMovie()
    {
        UiSkelton.WriteIndentedText4("Getting movie.");
        // Return the movie
    }
}