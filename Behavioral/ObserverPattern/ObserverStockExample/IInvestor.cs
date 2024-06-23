namespace AmrAmin.DesignPatterns.Behavioral.ObserverPattern.ObserverStockExample;
/// <summary> Observer /// </summary>
public interface IInvestor
{
    void Update(string symbol, double price);
}
