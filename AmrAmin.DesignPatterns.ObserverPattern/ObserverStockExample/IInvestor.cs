namespace AmrAmin.DesignPatterns.ObserverPattern.ObserverStockExample;
/// <summary> Observer /// </summary>
public interface IInvestor
{
    void Update(string symbol, double price);
}
