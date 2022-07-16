using Builder;
using B = Builder.Builders;

B.Builder builder = new B.ConcreteBuilder();

Director director = new(builder);
director.Construct();

Product product = builder.GetResult();
Console.WriteLine(product);