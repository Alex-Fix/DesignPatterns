namespace Builder.Builders;

internal class ConcreteBuilder : Builder
{
      private readonly Product _product = new();

      internal override void BuildPartA() => _product.Add("Part A");
      internal override void BuildPartB() => _product.Add("Part B");
      internal override void BuildPartC() => _product.Add("Part C");
      internal override Product GetResult() => _product;
}
