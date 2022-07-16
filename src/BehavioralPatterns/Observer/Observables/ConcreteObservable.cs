using Observer.Observers;

namespace Observer.Observables;

internal class ConcreteObservable : IObservable
{
      private readonly List<IObserver> _observers = new();

      public void AddObserver(IObserver o) => _observers.Add(o);
      public void RemoveObserver(IObserver o) => _observers.Remove(o);

      public void NotifyObservers()
      {
            foreach (IObserver o in _observers)
            {
                  o.Update();
            }
      }
}
