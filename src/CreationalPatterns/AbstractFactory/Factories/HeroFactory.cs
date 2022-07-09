using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factories;

internal abstract class HeroFactory
{
      internal abstract Weapon CreateWeapon();
      internal abstract Movement CreateMovement();
}
