using Flyweight.Flyweights;

namespace Flyweight;

internal class HouseFactory
{
      private readonly Dictionary<string, House> _houses = new();

      internal HouseFactory()
      {
            _houses.Add("Panel", new PanelHouse());
            _houses.Add("Brick", new BrickHouse());
      }

      internal House? GetHouse(string key)
      {
            _houses.TryGetValue(key, out House? house);
            return house;
      }
}
