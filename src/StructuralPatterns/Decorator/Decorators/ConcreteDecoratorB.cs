namespace Decorator.Decorators;

internal class ConcreteDecoratorB : Decorator
{
      internal override void Operation()
      {
            Console.WriteLine(nameof(ConcreteDecoratorB));
            base.Operation();
      }
}
