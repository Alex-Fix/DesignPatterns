namespace Composite.Components;

internal class Composite : Component
{
      private readonly List<Component> _children = new();

      internal Composite(string name) : base(name)
      {
      }

      internal override void Display()
      {
            Console.WriteLine(_name);

            foreach (Component component in _children)
            {
                  component.Display();
            }
      }

      internal override void Add(Component component) => _children.Add(component);
      internal override void Remove(Component component) => _children.Remove(component);
}
