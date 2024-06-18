namespace AmrAmin.DesignPatterns.TemplateMethodPattern;
using System;

public static class TemplateMethodExamples
{
    public static void RunExamples()
    {
        Console.WriteLine(" __________________________________________________________________________________");
        Console.WriteLine("/                                                                                  \\");
        Console.WriteLine("|      Use TemplateMethod to test the BrewingProcess example                        |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [START]                                        |");
        Console.WriteLine("|                                                                                   |");
        var coffee = new BrewCoffee();
        coffee.TemplateMethod();

        Console.WriteLine("|                                                                                   |");
        var tea = new BrewTea();
        tea.TemplateMethod();

        Console.WriteLine("|                                                                                   |");
        Console.WriteLine("|                                    [END]                                          |");
        Console.WriteLine("\\===================================================================================/");

    }
}
