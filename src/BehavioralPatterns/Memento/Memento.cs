namespace Memento;

internal class Memento
{
      internal Memento(string? state)
      {
            State = state;
      }

      internal string? State { get; set; }
}
