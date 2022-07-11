using Builder.Ingredients;

namespace Builder.Builders;

internal class RyeBreadBuilder : BreadBuilder
{
      internal override void SetFlour()
      {
            Bread.Flour = new Flour("Second grade rye flour");
      }

      internal override void SetSalt()
      {
            Bread.Salt = new Salt();
      }

      internal override void SetAdditives()
      {
      }
}
