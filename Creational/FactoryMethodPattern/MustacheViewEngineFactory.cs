namespace AmrAmin.DesignPatterns.Creational.FactoryMethodPattern;

public class MustacheViewEngineFactory : ViewEngineFactory
{
    public override IViewEngine CreateViewEngine()
    {
        return new MustacheViewEngine();
    }
}
