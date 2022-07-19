using Flyweight;
using Flyweight.Flyweights;

const int iterations = 5;

double longitude = 37.61;
double latitude = 55.74;

HouseFactory houseFactory = new();

for (int iteration = 0; iteration < iterations; ++iteration)
{
      House? panelHouse = houseFactory.GetHouse("Panel");
      panelHouse?.Build(longitude, latitude);
      longitude += 0.1;
      latitude += 0.1;
}

for (int iteration = 0; iteration < iterations; ++iteration)
{
      House? brickHouse = houseFactory.GetHouse("Brick");
      brickHouse?.Build(longitude, latitude);
      longitude += 0.1;
      latitude += 0.1;
}