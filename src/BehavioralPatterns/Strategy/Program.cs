using Strategy;
using Strategy.Movables;

var car = new Car();

car.Movable = new PetrolMove();
car.Move();

car.Movable = new ElectricMove();
car.Move();