namespace AmrAmin.DesignPatterns.Creational.FactoryMethodPattern;

// ConcreteCreator
public class RazorViewEngineFactory : ViewEngineFactory
{
    public override IViewEngine CreateViewEngine()
    {
        return new RazorViewEngine();
    }
}