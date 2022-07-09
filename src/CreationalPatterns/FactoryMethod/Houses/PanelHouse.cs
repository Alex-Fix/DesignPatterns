namespace FactoryMethod.Houses;

internal class PanelHouse : House
{
      internal PanelHouse(string developer) : base(developer)
      {
      }

      internal override string Message => $"I am {nameof(PanelHouse)} created by {_developer}";
}
