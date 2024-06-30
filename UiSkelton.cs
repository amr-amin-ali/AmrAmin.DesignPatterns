namespace AmrAmin.DesignPatterns;
using System;

public static class UiSkelton
{
    private static readonly string _space = "   ";

    public static void DrawHeader(string message)
    {
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine($"|  {message ?? ""}                                                                       ");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");
        Console.WriteLine("|                                                                                   |");
    }
    public static void DrawFooter()
    {
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/\n\n\n");
    }

    public static void DrawLineSeparator()
    {
        Console.WriteLine("|                                                                                   |");
    }
    public static void WriteIndentedText1
        (string text)
    {
        Console.WriteLine($"|{_space}{text}");
    }
    public static void WriteIndentedText2(string text)
    {
        Console.WriteLine($"|{_space}{_space}{text}");
    }
    public static void WriteIndentedText3(string text)
    {
        Console.WriteLine($"|{_space}{_space}{_space}{text}");
    }
    public static void WriteIndentedText4(string text)
    {
        Console.WriteLine($"|{_space}{_space}{_space}{_space}{text}");
    }
    public static void WriteIndentedText5(string text)
    {
        Console.WriteLine($"|{_space}{_space}{_space}{_space}{_space}{text}");
    }
}
