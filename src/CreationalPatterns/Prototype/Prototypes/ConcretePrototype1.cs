namespace Prototype.Prototypes;

internal class ConcretePrototype1 : Prototype
{
      internal ConcretePrototype1(int id) : base(id)
      {
      }

      internal override Prototype Clone() => new ConcretePrototype1(Id);
}
