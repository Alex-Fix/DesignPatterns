using Mediator.Collegues;

namespace Mediator.Mediators;

internal abstract class Mediator
{
      internal abstract void Send(string message, Collegue collegue);
}
