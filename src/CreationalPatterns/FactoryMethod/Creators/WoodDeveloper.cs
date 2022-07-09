using FactoryMethod.Products;

namespace FactoryMethod.Creators;

internal class WoodDeveloper : Developer
{
      internal WoodDeveloper(string name) : base(name)
      {
      }

      internal override House Create() => new WoodHouse(nameof(WoodDeveloper));
}
