using Observer.Observers;

namespace Observer.Observables;

internal class Stock : IObservable
{
      private readonly StockInfo _stockInfo = new();
      private readonly List<IObserver> _observers = new();

      public void RegisterObserver(IObserver o)
      {
            _observers.Add(o);
      }

      public void RemoveObserver(IObserver o)
      {
            _observers.Remove(o);
      }

      public void NotifyObservers()
      {
            foreach (IObserver o in _observers)
            {
                  o.Update(_stockInfo);
            }
      }

      internal void Market()
      {
            Random rnd = new(Guid.NewGuid().ToByteArray().Sum(b => b));

            _stockInfo.UAH = rnd.Next(40, 100);
            _stockInfo.USD = rnd.Next(1, 40);

            NotifyObservers();
      }
}

internal class StockInfo
{
      internal int USD { get; set; }
      internal int UAH { get; set; }
}