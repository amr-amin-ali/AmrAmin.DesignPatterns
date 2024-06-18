namespace AmrAmin.DesignPatterns.IteratorPattern;
using System;

using AmrAmin.DesignPatterns.IteratorPattern.BrowserExample;

public static class IteratorExamples
{
    public static void RunBrowserExample()
    {
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine("|      Use IteratorPattern to test the BROWSER example                              |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");

        var history = new BrowseHistory<string>();
        history.Push("https://www.example.com");
        history.Push("https://www.google.com");
        history.Push("https://www.github.com");

        var iterator = history.CreateIterator();
        while (iterator.HasNext())
        {
            Console.WriteLine("|      " + iterator.Current());
            iterator.Next();
        }






        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/");


    }
}
