namespace AmrAmin.DesignPatterns.Creational.FactoryMethodPattern;

// ConcreteProduct
public class RazorViewEngine : IViewEngine
{
    public string RenderView(string viewName, object model)
    {
        // Implement Razor view rendering logic
        UiSkelton.WriteIndentedText3($"Rendered {viewName} view using {nameof(RazorViewEngine)}");
        return $"Rendered {viewName} view using Razor";
    }
}