namespace Iterator.Iterators;

internal abstract class Iterator
{
      internal abstract object? First();
      internal abstract object? Next();
      internal abstract bool IsDone();
      internal abstract object? CurrentItem();
}
