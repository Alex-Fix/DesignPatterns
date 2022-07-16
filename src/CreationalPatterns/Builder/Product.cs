namespace Builder;

internal class Product
{
      private readonly List<string> _parts = new();

      internal void Add(string part)
      {
            _parts.Add(part);
      }

      public override string ToString() => string.Join(Environment.NewLine, _parts);
}
