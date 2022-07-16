namespace Builder.Builders;

internal abstract class Builder
{
      internal abstract void BuildPartA();
      internal abstract void BuildPartB();
      internal abstract void BuildPartC();
      internal abstract Product GetResult();
}
