using Strategy;
using Strategy.Strategies;

Context context = new();

context.ContextStrategy = new ConcreteStrategy1();
context.ExecuteAlgorithm();

context.ContextStrategy = new ConcreteStrategy2();
context.ExecuteAlgorithm();