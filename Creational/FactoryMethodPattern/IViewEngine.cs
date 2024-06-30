namespace AmrAmin.DesignPatterns.Creational.FactoryMethodPattern;
// Product
public interface IViewEngine
{
    string RenderView(string viewName, object model);
}
