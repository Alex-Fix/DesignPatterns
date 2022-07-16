using Observer.Observers;

namespace Observer.Observables;

internal interface IObservable
{
      void AddObserver(IObserver o);
      void RemoveObserver(IObserver o);
      void NotifyObservers();
}
