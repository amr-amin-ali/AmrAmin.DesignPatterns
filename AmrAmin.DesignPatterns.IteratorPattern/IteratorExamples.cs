namespace AmrAmin.DesignPatterns.IteratorPattern;
using System;

using AmrAmin.DesignPatterns.IteratorPattern.BrowserExample;
using AmrAmin.DesignPatterns.SharedKernel;

public static class IteratorExamples
{
    public static void RunExamples()
    {
        UiSkelton.DrawHeader("Use IteratorPattern to test the BROWSER example");



        var history = new BrowseHistory<string>();
        history.Push("https://www.example.com");
        history.Push("https://www.google.com");
        history.Push("https://www.github.com");

        var iterator = history.CreateIterator();
        while (iterator.HasNext())
        {
            UiSkelton.WriteIndentedText1(string.Empty);
            Console.WriteLine(iterator.Current());
            iterator.Next();
        }

        UiSkelton.DrawFooter();


    }
}
