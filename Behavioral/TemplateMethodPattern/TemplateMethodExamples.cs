namespace AmrAmin.DesignPatterns.Behavioral.TemplateMethodPattern;

using AmrAmin.DesignPatterns;

public static class TemplateMethodExamples
{
    public static void RunExamples()
    {
        UiSkelton.DrawHeader("Use TemplateMethod to test the BrewingProcess example");

        var coffee = new BrewCoffee();
        coffee.TemplateMethod();

        UiSkelton.DrawLineSeparator();

        var tea = new BrewTea();
        tea.TemplateMethod();

        UiSkelton.DrawFooter();
    }
}
