using FactoryMethod.Creators;
using FactoryMethod.Products;

Product product;
Creator creator;

creator = new ConcreteCreatorA();
product = creator.FactoryMethod();
Console.WriteLine(product.GetType().FullName);

creator = new ConcreteCreatorB();
product = creator.FactoryMethod();
Console.WriteLine(product.GetType().FullName);