using FactoryMethod.Products;

namespace FactoryMethod.Creators;

internal class ConcreteCreatorB : Creator
{
      internal override Product FactoryMethod() => new ConcreteProductB();
}
