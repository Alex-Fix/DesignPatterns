using P = Prototype.Prototypes;

namespace Prototype;

internal class Client
{
      internal void Opertaion()
      {
            P.Prototype prototype;

            prototype = new P.ConcretePrototype1(12);
            Console.WriteLine(prototype.Id);
            prototype = prototype.Clone();
            Console.WriteLine(prototype.Id);

            prototype = new P.ConcretePrototype2(22);
            Console.WriteLine(prototype.Id);
            prototype = prototype.Clone();
            Console.WriteLine(prototype.Id);
      }
}
