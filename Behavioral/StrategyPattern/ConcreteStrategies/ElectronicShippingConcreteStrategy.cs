namespace AmrAmin.DesignPatterns.Behavioral.StrategyPattern.ConcreteStrategies;

using AmrAmin.DesignPatterns.Behavioral.StrategyPattern;

public class ElectronicShippingConcreteStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for electronic products
        return 10.0;
    }
}
