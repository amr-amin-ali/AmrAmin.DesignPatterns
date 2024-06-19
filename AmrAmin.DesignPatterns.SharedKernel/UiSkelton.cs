namespace AmrAmin.DesignPatterns.SharedKernel;
using System;

public static class UiSkelton
{
    public delegate void Function();

    public static void DrawHeader(string message)
    {
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine($"|  ${message ?? ""}                                                                       ");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");
        Console.WriteLine("|                                                                                   |");
    }
    public static void DrawFooter()
    {
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/");
    }

    public static void DrawLineSeparator()
    {
        Console.WriteLine("|                                                                                   |");
    }
    public static void Indent1()
    {
        Console.Write("|        ");
    }
    public static void Indent2()
    {
        Console.Write("|                ");
    }
}
