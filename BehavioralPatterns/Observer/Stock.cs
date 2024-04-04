namespace BehavioralPatterns.Observer
{
    internal class Stock : IObservable
    {
        readonly StockData _stockData;
        List<IObserver> observers;

        public Stock()
        {
            observers = new List<IObserver>();
            _stockData = new StockData();
        }
        public void NotifyObservers()
        {
            foreach(var obs in observers)
                obs.Update(_stockData);
        }

        public void Market()
        {
            Random rnd = new Random();
            _stockData.USD = rnd.Next(70, 90);
            _stockData.Euro = rnd.Next(80, 100);
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
