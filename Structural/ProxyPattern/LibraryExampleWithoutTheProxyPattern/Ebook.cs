namespace AmrAmin.DesignPatterns.Structural.ProxyPattern.LibraryExampleWithoutTheProxyPattern;
public class Ebook
{
    public string FileName { get; }
    public Ebook(string fileName)
    {
        FileName = fileName;
        Load();
    }
    private void Load()
    {
        UiSkelton.WriteIndentedText3($"Loading Book: {FileName}");
    }
    public void Show()
    {
        UiSkelton.WriteIndentedText3($"Showing Book: {FileName}");
    }
}
