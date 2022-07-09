using FactoryMethod.Houses;

namespace FactoryMethod.Developers;

internal abstract class Developer
{
      internal Developer(string name)
      {
            Name = name;
      }

      internal string Name { get; set; }

      internal abstract House Create();
}