using AbstractFactory.Products;

namespace AbstractFactory.Factories;

internal abstract class AbstractFactory
{
      internal abstract AbstractProductA CreateProductA();
      internal abstract AbstractProductB CreateProductB();
}
