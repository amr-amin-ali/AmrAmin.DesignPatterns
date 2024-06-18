namespace AmrAmin.DesignPatterns.Strategy_Pattern.ConcreteStrategies;
public class ClothingShippingConcreteStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for clothing
        return 7.5;
    }
}

