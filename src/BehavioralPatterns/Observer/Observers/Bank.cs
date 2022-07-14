using Observer.Observables;

namespace Observer.Observers;

internal class Bank : IObserver
{
      private readonly string _name;
      IObservable _stock;

      internal Bank(string name, IObservable stock)
      {
            _name = name;
            _stock = stock;

            _stock.RegisterObserver(this);
      }

      public void Update(object o)
      {
            StockInfo stockInfo = (StockInfo)o;

            if (stockInfo.UAH < 75)
            {
                  Console.WriteLine($"Bank {_name} buys UAH for {stockInfo.UAH}");
                  return;
            }

            Console.WriteLine($"Bank {_name} sells UAH for {stockInfo.UAH}");
      }
}
