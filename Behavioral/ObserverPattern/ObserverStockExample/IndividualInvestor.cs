namespace AmrAmin.DesignPatterns.Behavioral.ObserverPattern.ObserverStockExample;

using AmrAmin.DesignPatterns;

public class IndividualInvestor : IInvestor
{
    private readonly string _name;

    public IndividualInvestor(string name)
    {
        _name = name;
    }

    public void Update(string symbol, double price)
    {
        UiSkelton.WriteIndentedText1($"{_name} received an update: {symbol} is now at ${price}");
        UiSkelton.DrawLineSeparator();
    }
}

