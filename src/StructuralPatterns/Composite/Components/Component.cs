namespace Composite.Components;

internal abstract class Component
{
      protected string _name;

      internal Component(string name)
      {
            _name = name;
      }

      internal abstract void Display();
      internal abstract void Add(Component component);
      internal abstract void Remove(Component component);
}
