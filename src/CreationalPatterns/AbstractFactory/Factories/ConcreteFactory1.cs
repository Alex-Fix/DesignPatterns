using AbstractFactory.Products;

namespace AbstractFactory.Factories;

internal class ConcreteFactory1 : AbstractFactory
{
      internal override AbstractProductA CreateProductA() => new ProductA1();
      internal override AbstractProductB CreateProductB() => new ProductB1();
}
