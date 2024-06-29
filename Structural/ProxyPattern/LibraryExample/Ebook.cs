namespace AmrAmin.DesignPatterns.Structural.ProxyPattern.LibraryExample;
public class Ebook : IEbook
{
    public string Name { get; }
    public Ebook(string fileName)
    {
        Name = fileName;
        Load();
    }

    private void Load()
    {
        // Load the ebook content from a file or database
        UiSkelton.WriteIndentedText3($"Book \"{Name}\" is  loading from file or database...");
    }

    public void Show()
    {
        // Display the ebook content
        UiSkelton.WriteIndentedText3($"Showing ebook: {Name}");
    }
}