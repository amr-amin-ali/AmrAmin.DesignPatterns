namespace AmrAmin.DesignPatterns.Strategy_Pattern.ConcreteStrategies;
public class ElectronicShippingConcreteStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for electronic products
        return 10.0;
    }
}
