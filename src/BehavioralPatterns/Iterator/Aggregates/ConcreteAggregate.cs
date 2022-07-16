using System.Collections;
using I = Iterator.Iterators;

namespace Iterator.Aggregates;

internal class ConcreteAggregate : Aggregate
{
      private readonly ArrayList _items = new();

      internal override int Count => _items.Count;

      internal override object? this[int index]
      {
            get => _items[index];
            set => _items[index] = value;
      }

      internal override I.Iterator CreateIterator() => new I.ConcreteIterator(this);
}