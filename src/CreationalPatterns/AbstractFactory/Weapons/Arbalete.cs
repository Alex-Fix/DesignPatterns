namespace AbstractFactory.Weapons;

internal class Arbalete : Weapon
{
      internal override void Hit() => Console.WriteLine($"{nameof(Arbalete)} hit");
}
