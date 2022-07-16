namespace Prototype.Prototypes;

internal abstract class Prototype
{
      internal Prototype(int id)
      {
            Id = id;
      }

      internal int Id { get; private set; }

      internal abstract Prototype Clone();
}
