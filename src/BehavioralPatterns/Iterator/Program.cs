using Iterator.Aggregates;
using I = Iterator.Iterators;

Aggregate aggregate = new ConcreteAggregate();
I.Iterator iterator = aggregate.CreateIterator();

object? item = iterator.First();
while (!iterator.IsDone())
{
      item = iterator.Next();
}