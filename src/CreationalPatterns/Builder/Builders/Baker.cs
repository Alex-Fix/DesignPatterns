using Builder.Ingredients;

namespace Builder.Builders;

internal class Baker
{
      internal Bread Bake(BreadBuilder breadBuilder)
      {
            breadBuilder.CreateBread();

            breadBuilder.SetFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();

            return breadBuilder.Bread;
      }
}
