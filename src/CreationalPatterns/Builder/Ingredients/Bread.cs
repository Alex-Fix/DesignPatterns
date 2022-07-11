using System.Text;

namespace Builder.Ingredients;

internal class Bread
{
      internal Flour? Flour { get; set; }
      internal Salt? Salt { get; set; }
      internal Additives? Additives { get; set; }

      public override string ToString()
      {
            var sb = new StringBuilder();

            if (Flour is not null)
            {
                  sb.AppendLine($"{nameof(Flour)}: {Flour.Sort}");
            }

            sb.AppendLine($"{nameof(Salt)}: {(Salt is not null ? "yes" : "no")}");

            if (Additives is not null)
            {
                  sb.AppendLine($"{nameof(Additives)}: {Additives.Name}");
            }

            return sb.ToString();
      }
}
