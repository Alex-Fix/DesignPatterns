namespace Observer.Observers;

internal class ConcreteObserver : IObserver
{
      private readonly string _name;

      internal ConcreteObserver(string name)
      {
            _name = name;
      }

      public void Update() => Console.WriteLine(_name);
}