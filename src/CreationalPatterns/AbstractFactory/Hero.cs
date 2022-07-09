using AbstractFactory.Factories;
using AbstractFactory.Movements;
using AbstractFactory.Weapons;

internal class Hero
{
      private readonly Weapon _weapon;
      private readonly Movement _movement;

      internal Hero(HeroFactory factory)
      {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
      }

      internal void Hit() => _weapon.Hit();

      internal void Move() => _movement.Move();
}
