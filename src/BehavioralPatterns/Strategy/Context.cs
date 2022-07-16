using Strategy.Strategies;

namespace Strategy;

internal class Context
{
      internal IStrategy? ContextStrategy { get; set; }

      internal void ExecuteAlgorithm() => ContextStrategy?.Algorithm();
}
