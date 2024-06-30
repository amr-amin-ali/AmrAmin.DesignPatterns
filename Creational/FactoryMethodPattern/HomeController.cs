namespace AmrAmin.DesignPatterns.Creational.FactoryMethodPattern;

// Controller
public class HomeController
{
    private readonly IViewEngine _viewEngine;

    public HomeController(ViewEngineFactory viewEngineFactory)
    {
        UiSkelton.WriteIndentedText2($"{nameof(HomeController)} is asking the view engine factory to create the view engine instance.");
        _viewEngine = viewEngineFactory.CreateViewEngine();
    }

    public string Index()
    {
        var model = new { Message = "Hello, world!" };
        return _viewEngine.RenderView("Index", model);
    }
}