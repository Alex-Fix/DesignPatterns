using Bridge.Implementors;

namespace Bridge.Abstractions;

internal abstract class Abstraction
{
      internal Abstraction(Implementor implementor)
      {
            Implementor = implementor;
      }

      internal Implementor Implementor { get; set; }

      internal virtual void Operation()
      {
            Console.WriteLine(nameof(Abstraction));
            Implementor.OperationImp();
      }
}
