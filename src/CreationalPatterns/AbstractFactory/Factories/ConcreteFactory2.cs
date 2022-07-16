using AbstractFactory.Products;

namespace AbstractFactory.Factories;

internal class ConcreteFactory2 : AbstractFactory
{
      internal override AbstractProductA CreateProductA() => new ProductA2();
      internal override AbstractProductB CreateProductB() => new ProductB2();
}