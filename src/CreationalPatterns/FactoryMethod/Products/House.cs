namespace FactoryMethod.Products;

internal abstract class House
{
      protected string _developer;

      internal House(string developer)
      {
            _developer = developer;
      }

      internal abstract string Message { get; }
}
