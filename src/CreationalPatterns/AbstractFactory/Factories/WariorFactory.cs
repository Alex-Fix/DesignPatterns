using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories;

internal class WariorFactory : HeroFactory
{
      internal override Movement CreateMovement() => new RunMovement();

      internal override Weapon CreateWeapon() => new Sward();
}
