namespace AmrAmin.DesignPatterns.Strategy_Pattern;

// Strategy Interface
public interface IShippingStrategy
{
    double CalculateShippingCost(DeliveryAddress address);
}

