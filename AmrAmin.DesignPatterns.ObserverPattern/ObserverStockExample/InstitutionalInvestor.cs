namespace AmrAmin.DesignPatterns.ObserverPattern.ObserverStockExample;

using AmrAmin.DesignPatterns.SharedKernel;
public class InstitutionalInvestor : IInvestor
{
    private readonly string _name;

    public InstitutionalInvestor(string name)
    {
        _name = name;
    }

    public void Update(string symbol, double price)
    {
        UiSkelton.Indent1();
        Console.WriteLine($"{_name} received an update: {symbol} is now at ${price}");
        UiSkelton.DrawLineSeparator();
        // Institutional investors may have more complex logic to handle the update
    }
}
