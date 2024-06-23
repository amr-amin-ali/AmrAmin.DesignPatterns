namespace AmrAmin.DesignPatterns.Behavioral.StrategyPattern.ConcreteStrategies;

using AmrAmin.DesignPatterns.Behavioral.StrategyPattern;

public class BookShippingConcreteStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for books
        return 5.0;
    }
}
