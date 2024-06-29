namespace AmrAmin.DesignPatterns.Structural.ProxyPattern.LibraryExample;
public class Library
{
    private readonly Dictionary<string, IEbook> _ebooks = new Dictionary<string, IEbook>();
    private readonly int _count;

    public void Add(IEbook ebook)
    {
        _ebooks.Add(ebook.Name, ebook);
    }

    public void OpenEbook(string fileName)
    {
        UiSkelton.WriteIndentedText2($"Library is opening the book \"{fileName}\" by calling the ebook proxy...");
        foreach (var ebook in _ebooks)
        {
            // if the book exist > show it > and > break
            if (ebook.Key == fileName)
            {
                ebook.Value.Show();
                return;
            }
        }
        // if book does not exist > add it as proxy > then > show it
        EbookProxy proxy = new EbookProxy(fileName);
        Add(proxy);
        proxy.Show();
    }
}