using Decorator.Components;
using D = Decorator.Decorators;

Component component = new ConcreteComponent();

D.Decorator decoratorA = new D.ConcreteDecoratorA();
decoratorA.SetComponent(component);
decoratorA.Operation();

Console.WriteLine();

D.Decorator decoratorB = new D.ConcreteDecoratorB();
decoratorB.SetComponent(decoratorA);
decoratorB.Operation();