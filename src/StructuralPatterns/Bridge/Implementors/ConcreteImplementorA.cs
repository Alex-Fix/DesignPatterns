namespace Bridge.Implementors;

internal class ConcreteImplementorA : Implementor
{
      internal override void OperationImp() => Console.WriteLine(nameof(ConcreteImplementorA));
}
