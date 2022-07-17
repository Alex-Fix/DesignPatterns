using M = Mediator.Mediators;

namespace Mediator.Collegues;

internal abstract class Collegue
{
      protected readonly M.Mediator _mediator;

      internal Collegue(M.Mediator mediator)
      {
            _mediator = mediator;
      }

      internal virtual void Send(string message) => _mediator.Send(message, this);

      internal abstract void Notify(string message);
}
