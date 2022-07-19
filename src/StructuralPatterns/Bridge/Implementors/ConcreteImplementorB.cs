namespace Bridge.Implementors;

internal class ConcreteImplementorB : Implementor
{
      internal override void OperationImp() => Console.WriteLine(nameof(ConcreteImplementorB));
}