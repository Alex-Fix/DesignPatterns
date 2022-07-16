using I = Iterator.Iterators;

namespace Iterator.Aggregates;

internal abstract class Aggregate
{
      internal abstract int Count { get; }
      internal abstract object? this[int index] { get; set; }

      internal abstract I.Iterator CreateIterator();
}
