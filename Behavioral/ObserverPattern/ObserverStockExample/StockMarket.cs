namespace AmrAmin.DesignPatterns.Behavioral.ObserverPattern.ObserverStockExample;

/// <summary> Subject /// </summary>
public class StockMarket
{
    private readonly Dictionary<string, double> _stockPrices;
    private readonly List<IInvestor> _investors;

    public StockMarket()
    {
        _stockPrices = new Dictionary<string, double>();
        _investors = new List<IInvestor>();
    }

    public void AddStock(string symbol, double price)
    {
        _stockPrices[symbol] = price;
        NotifyInvestors(symbol, price);
    }

    public void RemoveStock(string symbol)
    {
        if (_stockPrices.ContainsKey(symbol))
        {
            _stockPrices.Remove(symbol);
            NotifyInvestors(symbol, 0.0);
        }
    }

    public void AttachInvestor(IInvestor investor)
    {
        _investors.Add(investor);
    }

    public void DetachInvestor(IInvestor investor)
    {
        _investors.Remove(investor);
    }

    private void NotifyInvestors(string symbol, double price)
    {
        foreach (var investor in _investors)
        {
            investor.Update(symbol, price);
        }
    }
}
