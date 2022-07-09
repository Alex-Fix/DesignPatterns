namespace AbstractFactory.Weapons;

internal class Sward : Weapon
{
      internal override void Hit() => Console.WriteLine($"{nameof(Sward)} hit");
}
