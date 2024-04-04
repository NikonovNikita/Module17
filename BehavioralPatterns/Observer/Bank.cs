namespace BehavioralPatterns.Observer
{
    internal class Bank : IObserver
    {
        IObservable stock;

        public Bank(IObservable observable)
        {
            stock = observable;
            stock.RegisterObserver(this);
        }

        public void Update(object o)
        {
            StockData stockData = (StockData)o;

            if(stockData.Euro > 85)
                Console.WriteLine($"Банк продает евро по курсу: {stockData.Euro}");
            else
                Console.WriteLine($"Банк покупает евро по курсу: {stockData.Euro}");

        }
    }
}
