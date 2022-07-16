using Observer.Observables;
using Observer.Observers;

IObserver observerA = new ConcreteObserver("Observer A");
IObserver observerB = new ConcreteObserver("Observer B");

IObservable observable = new ConcreteObservable();

observable.AddObserver(observerA);
observable.AddObserver(observerB);

observable.NotifyObservers();

observable.RemoveObserver(observerA);

observable.NotifyObservers();
