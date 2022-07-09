using FactoryMethod.Houses;

namespace FactoryMethod.Developers;

internal class PanelDeveloper : Developer
{
      internal PanelDeveloper(string name) : base(name)
      {
      }

      internal override House Create() => new PanelHouse(nameof(PanelDeveloper));
}
