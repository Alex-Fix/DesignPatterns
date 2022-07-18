namespace Composite.Components;

internal class Leaf : Component
{
      internal Leaf(string name) : base(name)
      {
      }

      internal override void Display() => Console.WriteLine(_name);
      internal override void Add(Component component) => throw new NotImplementedException();
      internal override void Remove(Component component) => throw new NotImplementedException();
}