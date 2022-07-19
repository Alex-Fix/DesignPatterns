using Bridge.Implementors;

namespace Bridge.Abstractions;

internal class RefinedAbstraction : Abstraction
{
      internal RefinedAbstraction(Implementor implementor) : base(implementor)
      {
      }

      internal override void Operation()
      {
            Console.WriteLine(nameof(RefinedAbstraction));
            Implementor.OperationImp();
      }
}
