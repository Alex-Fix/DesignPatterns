using FactoryMethod.Products;

namespace FactoryMethod.Creators;

internal class ConcreteCreatorA : Creator
{
      internal override Product FactoryMethod() => new ConcreteProductA();
}
