namespace AmrAmin.DesignPatterns.Structural.ProxyPattern.LibraryExample;
public class EbookProxy : IEbook
{
    public string Name { get; }
    private Ebook _ebook;

    public EbookProxy(string fileName)
    {
        Name = fileName;
    }

    public void Show()
    {
        UiSkelton.WriteIndentedText2($"EbookProxy is loading \"{Name}\" book...");
        _ebook ??= new Ebook(Name);
        _ebook.Show();
    }
}