using FactoryMethod.Products;

namespace FactoryMethod.Creators;

internal abstract class Developer
{
      internal Developer(string name)
      {
            Name = name;
      }

      internal string Name { get; set; }

      internal abstract House Create();
}