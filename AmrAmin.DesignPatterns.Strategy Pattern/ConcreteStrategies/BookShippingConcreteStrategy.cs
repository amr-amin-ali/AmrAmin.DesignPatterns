namespace AmrAmin.DesignPatterns.Strategy_Pattern.ConcreteStrategies;
public class BookShippingConcreteStrategy : IShippingStrategy
{
    public double CalculateShippingCost(DeliveryAddress address)
    {
        // Logic to calculate shipping cost for books
        return 5.0;
    }
}
