using Observer.Observables;
using Observer.Observers;

Stock stock = new();

Bank bank = new("FixBank", stock);
Broker broker = new("Alex", stock);

stock.Market();

broker.StockTrade();

stock.Market();