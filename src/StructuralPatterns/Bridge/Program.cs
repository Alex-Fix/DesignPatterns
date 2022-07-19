using Bridge.Abstractions;
using Bridge.Implementors;

Abstraction abstraction;

abstraction = new RefinedAbstraction(new ConcreteImplementorA());
abstraction.Operation();
Console.WriteLine();

abstraction.Implementor = new ConcreteImplementorB();
abstraction.Operation();