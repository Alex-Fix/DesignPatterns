using Strategy.Movables;

namespace Strategy;

internal class Car
{
      internal IMovable? Movable { get; set; }

      internal void Move()
      {
            Movable?.Move();
      }
}
