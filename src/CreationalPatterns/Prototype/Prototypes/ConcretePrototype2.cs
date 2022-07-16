namespace Prototype.Prototypes;

internal class ConcretePrototype2 : Prototype
{
      internal ConcretePrototype2(int id) : base(id)
      {
      }

      internal override Prototype Clone() => new ConcretePrototype2(Id);
}