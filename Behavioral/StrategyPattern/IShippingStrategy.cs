namespace AmrAmin.DesignPatterns.Behavioral.StrategyPattern;

// Strategy Interface
public interface IShippingStrategy
{
    double CalculateShippingCost(DeliveryAddress address);
}

