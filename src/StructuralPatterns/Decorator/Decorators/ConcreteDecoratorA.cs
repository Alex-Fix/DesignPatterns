namespace Decorator.Decorators;

internal class ConcreteDecoratorA : Decorator
{
      internal override void Operation()
      {
            Console.WriteLine(nameof(ConcreteDecoratorA));
            base.Operation();
      }
}
