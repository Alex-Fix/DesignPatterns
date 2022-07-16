using AbstractFactory.Products;

internal class Client
{
      private readonly AbstractProductA _productA;
      private readonly AbstractProductB _productB;

      internal Client(AbstractFactory.Factories.AbstractFactory factory)
      {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
      }

      internal void Run()
      {
            Console.WriteLine(_productA.GetType().FullName);
            Console.WriteLine(_productB.GetType().FullName);
      }
}
