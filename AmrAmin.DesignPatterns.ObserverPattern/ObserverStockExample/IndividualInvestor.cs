namespace AmrAmin.DesignPatterns.ObserverPattern.ObserverStockExample;

using AmrAmin.DesignPatterns.SharedKernel;

public class IndividualInvestor : IInvestor
{
    private readonly string _name;

    public IndividualInvestor(string name)
    {
        _name = name;
    }

    public void Update(string symbol, double price)
    {
        UiSkelton.Indent1();
        Console.WriteLine($"{_name} received an update: {symbol} is now at ${price}");
        UiSkelton.DrawLineSeparator();
    }
}

