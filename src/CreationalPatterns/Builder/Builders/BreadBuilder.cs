using Builder.Ingredients;

namespace Builder.Builders;

internal abstract class BreadBuilder
{
      internal Bread Bread { get; private set; } = null!;

      internal void CreateBread()
      {
            Bread = new Bread();
      }

      internal abstract void SetFlour();
      internal abstract void SetSalt();
      internal abstract void SetAdditives();
}
