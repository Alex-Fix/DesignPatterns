namespace Flyweight.Flyweights;

internal class PanelHouse : House
{
      internal PanelHouse()
      {
            _stages = 16;
      }

      internal override void Build(double longitude, double latitude) => Console.WriteLine($"Panel house was built. Stages: {_stages}, longitude: {longitude}, latitude: {latitude}");
}
