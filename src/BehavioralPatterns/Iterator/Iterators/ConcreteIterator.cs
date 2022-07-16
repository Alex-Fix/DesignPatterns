using Iterator.Aggregates;

namespace Iterator.Iterators;

internal class ConcreteIterator : Iterator
{
      private readonly Aggregate _aggregate;
      private int _current;

      internal ConcreteIterator(Aggregate aggregate)
      {
            _aggregate = aggregate;
      }

      internal override object? First() => _aggregate.Count > 0 ? _aggregate[0] : null;

      internal override object? Next()
      {
            _current++;

            if (!IsDone())
            {
                  return _aggregate[_current];
            }

            return null;
      }

      internal override object? CurrentItem() => !IsDone() ? _aggregate[_current] : null;

      internal override bool IsDone() => _current >= _aggregate.Count;
}
