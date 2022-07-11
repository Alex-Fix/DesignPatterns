using Builder.Ingredients;

namespace Builder.Builders;

internal class WheatBreadBuilder : BreadBuilder
{
      internal override void SetFlour()
      {
            Bread.Flour = new Flour("First grade wheat flour");
      }

      internal override void SetSalt()
      {
            Bread.Salt = new Salt();
      }

      internal override void SetAdditives()
      {
            Bread.Additives = new Additives("Raisins");
      }
}
