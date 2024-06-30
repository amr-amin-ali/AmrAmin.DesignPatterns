namespace AmrAmin.DesignPatterns.Creational.BuilderPattern;
public class Slide
{
    private string _title;
    private string _content;

    public string Title
    {
        get => _title;
        set => _title = value;
    }

    public string Content
    {
        get => _content;
        set => _content = value;
    }

    public Slide(string title, string content)
    {
        _title = title;
        _content = content;
    }
}