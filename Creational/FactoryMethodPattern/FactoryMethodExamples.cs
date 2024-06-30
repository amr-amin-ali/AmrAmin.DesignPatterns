namespace AmrAmin.DesignPatterns.Creational.FactoryMethodPattern;
public static class FactoryMethodExamples
{
    public static void RunExamples()
    {
        ViewEngineExample();
    }
    private static void ViewEngineExample()
    {
        UiSkelton.DrawHeader("Use FactoryMethodPattern to test the ViewEngine example.");

        UiSkelton.WriteIndentedText1("Use the Razor view engine");
        var razorViewEngineFactory = new RazorViewEngineFactory();
        UiSkelton.WriteIndentedText1("Call Home controller with the Razor view engine");
        var homeController = new HomeController(razorViewEngineFactory);
        var razorViewResult = homeController.Index(); // "Rendered Index view using Razor"


        UiSkelton.WriteIndentedText1("Use the Mustache view engine");
        var mustacheViewEngineFactory = new MustacheViewEngineFactory();
        UiSkelton.WriteIndentedText1("Call Home controller with the Mustache view engine");
        var homeController2 = new HomeController(mustacheViewEngineFactory);
        var mustacheViewResult = homeController2.Index(); // "Rendered Index view using Mustache"

        UiSkelton.DrawFooter();
    }
}
