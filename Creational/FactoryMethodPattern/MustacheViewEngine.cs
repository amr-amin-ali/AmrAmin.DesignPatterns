namespace AmrAmin.DesignPatterns.Creational.FactoryMethodPattern;

public class MustacheViewEngine : IViewEngine
{
    public string RenderView(string viewName, object model)
    {
        // Implement Mustache view rendering logic
        UiSkelton.WriteIndentedText3($"Rendered {viewName} view using {nameof(MustacheViewEngine)}");
        return $"Rendered {viewName} view using Mustache";
    }
}
