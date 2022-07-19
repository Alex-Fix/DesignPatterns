namespace Flyweight.Flyweights;

internal class BrickHouse : House
{
      internal BrickHouse()
      {
            _stages = 5;
      }

      internal override void Build(double longitude, double latitude) => Console.WriteLine($"Brick house was built. Stages: {_stages}, longitude: {longitude}, latitude: {latitude}");
}