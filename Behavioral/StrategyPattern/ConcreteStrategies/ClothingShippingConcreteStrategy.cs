namespace AmrAmin.DesignPatterns.Behavioral.StrategyPattern.ConcreteStrategies;

using AmrAmin.DesignPatterns.Behavioral.StrategyPattern;

public class ClothingShippingConcreteStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for clothing
        return 7.5;
    }
}

