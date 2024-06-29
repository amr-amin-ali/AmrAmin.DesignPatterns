namespace AmrAmin.DesignPatterns.Structural.ProxyPattern;
using AmrAmin.DesignPatterns.Structural.ProxyPattern.GangOfFour;
using AmrAmin.DesignPatterns.Structural.ProxyPattern.LibraryExample;

using No = AmrAmin.DesignPatterns.Structural.ProxyPattern.LibraryExampleWithoutTheProxyPattern;

public static class ProxyExamples
{
    public static void RunExamples()
    {
        RunLibraryExampleWithoutTheProxyPattern();
        RunLibraryWithTheProxyExample();
        RunGangOfFourExample();
    }

    private static void RunGangOfFourExample()
    {
        UiSkelton.DrawHeader("Use ProxyPattern to test the GangOfFour example.");

        UiSkelton.WriteIndentedText1("Creating Proxy.");
        ISubject proxy = new Proxy();
        proxy.Request(); // Output: RealSubject handling request.

        UiSkelton.DrawFooter();
    }
    private static void RunLibraryWithTheProxyExample()
    {
        UiSkelton.DrawHeader("Use ProxyPattern to test the Library example.");

        UiSkelton.WriteIndentedText1("Createing a new library");
        Library library = new Library();

        // Add some ebooks to the library
        string[] listOfBooksNames = ["AAAAA", "BBBBBB", "CCCCC"];
        foreach (var bookName in listOfBooksNames)
        {
            UiSkelton.WriteIndentedText1($"Add book \"{bookName}\" to the library");
            library.Add(new EbookProxy(bookName));
        }

        // Open the ebooks
        UiSkelton.WriteIndentedText1($"Opening book \"{listOfBooksNames[0]}\" from the library");
        library.OpenEbook(listOfBooksNames[0]);
        UiSkelton.WriteIndentedText1($"Opening book \"{listOfBooksNames[1]}\" from the library");
        library.OpenEbook(listOfBooksNames[1]);
        UiSkelton.WriteIndentedText1($"Opening book \"{listOfBooksNames[2]}\" from the library");
        library.OpenEbook(listOfBooksNames[2]);



        UiSkelton.DrawFooter();
    }
    private static void RunLibraryExampleWithoutTheProxyPattern()
    {
        UiSkelton.DrawHeader("Test the Library example without the proxy pattern.");

        UiSkelton.WriteIndentedText1("Createing a new library");
        var library = new No.Library();
        // Add some ebooks to the library
        string[] listOfBooksNames = ["AAAAA", "BBBBBB", "CCCCC"];
        foreach (var bookName in listOfBooksNames)
        {
            UiSkelton.WriteIndentedText1($"Add book \"{bookName}\" to the library");
            library.Add(new No.Ebook(bookName));
        }
        UiSkelton.WriteIndentedText1($"Opening book \"{listOfBooksNames[0]}\" from the library");
        library.OpenBook(listOfBooksNames[0]);

        UiSkelton.WriteIndentedText1(@"Notice how not only the required book was loaded,
               but also other books were loaded.
                  SO, let's use the PROXY design pattern to solve this problem.");

        UiSkelton.DrawFooter();
    }
}

