namespace FactoryMethod.Products;

internal class WoodHouse : House
{
      internal WoodHouse(string developer) : base(developer)
      {
      }

      internal override string Message => $"I am {nameof(WoodHouse)} created by {_developer}";
}
