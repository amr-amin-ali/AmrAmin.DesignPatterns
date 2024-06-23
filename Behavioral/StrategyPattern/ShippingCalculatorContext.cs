namespace AmrAmin.DesignPatterns.Behavioral.StrategyPattern;
public class ShippingCalculatorContext
{
    private IShippingStrategy _shippingStrategy;

    public void SetShippingStrategy(IShippingStrategy strategy)
    {
        _shippingStrategy = strategy;
    }

    public double CalculateShippingCost(DeliveryAddress address)
    {
        return _shippingStrategy.CalculateShippingCost(address);
    }
}

