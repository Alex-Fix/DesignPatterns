using B = Builder.Builders;

namespace Builder;

internal class Director
{
      private readonly B.Builder _builder;

      internal Director(B.Builder builder)
      {
            _builder = builder;
      }

      internal void Construct()
      {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
      }
}
