namespace Strategy.Strategies;

internal class ConcreteStrategy1 : IStrategy
{
      public void Algorithm() => Console.WriteLine(nameof(ConcreteStrategy1));
}
