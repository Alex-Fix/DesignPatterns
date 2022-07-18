namespace Decorator.Components;

internal class ConcreteComponent : Component
{
      internal override void Operation() => Console.WriteLine(nameof(ConcreteComponent));
}