namespace Memento;

internal class Originator
{
      internal string? State { get; set; }

      internal void SetMemento(Memento memento) => State = memento.State;

      internal Memento CreateMemento() => new Memento(State);
}