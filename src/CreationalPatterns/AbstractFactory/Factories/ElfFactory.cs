using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories;

internal class ElfFactory : HeroFactory
{
      internal override Movement CreateMovement() => new FlyMovement();

      internal override Weapon CreateWeapon() => new Arbalete();
}
