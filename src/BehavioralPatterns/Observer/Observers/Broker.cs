using Observer.Observables;

namespace Observer.Observers;

internal class Broker : IObserver
{
      private readonly string _name;
      private IObservable? _stock;

      internal Broker(string name, IObservable stock)
      {
            _name = name;
            _stock = stock;

            _stock.RegisterObserver(this);
      }

      public void Update(object o)
      {
            StockInfo stockInfo = (StockInfo)o;

            if (stockInfo.USD < 20)
            {
                  Console.WriteLine($"Broker {_name} buys USD for {stockInfo.USD}");
                  return;
            }

            Console.WriteLine($"Broker {_name} sells USD for {stockInfo.USD}");
      }

      internal void StockTrade()
      {
            _stock?.RemoveObserver(this);
            _stock = null;
      }
}
