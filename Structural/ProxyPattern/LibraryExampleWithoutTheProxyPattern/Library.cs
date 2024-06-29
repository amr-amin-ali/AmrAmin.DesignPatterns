namespace AmrAmin.DesignPatterns.Structural.ProxyPattern.LibraryExampleWithoutTheProxyPattern;
public class Library
{
    private readonly Dictionary<string, Ebook> _ebooks = new Dictionary<string, Ebook>();

    public void Add(Ebook ebook)
    {
        _ebooks.Add(ebook.FileName, ebook);
    }

    public void OpenBook(string fileName)
    {
        _ebooks[fileName].Show();
    }
}
