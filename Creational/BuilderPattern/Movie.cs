namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
public class Movie
{
    private readonly List<string> _videoClips;

    public Movie()
    {
        _videoClips = new List<string>();
    }

    public void AddVideoClip(string clip)
    {
        UiSkelton.WriteIndentedText5("Adding video clip to the Movie");
        _videoClips.Add(clip);
    }

    public void Render()
    {
        UiSkelton.WriteIndentedText5("Rendering the video clip.");
    }
}