namespace BehavioralPatterns.Observer;

internal class Broker : IObserver
{
    IObservable stock;

    public Broker(IObservable observable)
    {
        stock = observable;
        stock.RegisterObserver(this);
    }
    public void Update(object o)
    {
        var stockData = (StockData)o;

        if(stockData.USD > 85)
            Console.WriteLine($"Брокер продает доллары по курсу: {stockData.USD}");
        else
            Console.WriteLine($"Брокер покупает доллары по курсу: {stockData.USD}");
    }

    public void StopTrade()
    {
        stock.RemoveObserver(this);
    }
}
