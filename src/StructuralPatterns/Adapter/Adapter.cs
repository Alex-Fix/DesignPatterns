namespace Adapter;

internal class Adapter : Target
{
      private readonly Adaptee _ataptee = new();

      internal override void Request() => _ataptee.SpecificRequest();
}
