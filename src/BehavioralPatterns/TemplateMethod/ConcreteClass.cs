namespace TemplateMethod;

internal class ConcreteClass : AbstractClass
{
      internal override void Operation1() => Console.WriteLine(nameof(Operation1));
      internal override void Operation2() => Console.WriteLine(nameof(Operation2));
}