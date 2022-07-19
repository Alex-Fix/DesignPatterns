namespace Flyweight.Flyweights;

/// <summary>
/// Flyweight
/// </summary>
internal abstract class House
{
      protected int _stages;

      internal abstract void Build(double longitude, double latitude);
}
