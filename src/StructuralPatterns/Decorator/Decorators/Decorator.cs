using Decorator.Components;

namespace Decorator.Decorators;

internal abstract class Decorator : Component
{
      protected Component? _component;

      internal void SetComponent(Component component) => _component = component;

      internal override void Operation() => _component?.Operation();
}
