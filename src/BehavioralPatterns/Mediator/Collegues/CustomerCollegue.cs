using M = Mediator.Mediators;

namespace Mediator.Collegues;

internal class CustomerCollegue : Collegue
{
      internal CustomerCollegue(M.Mediator mediator) : base(mediator)
      {
      }

      internal override void Notify(string message) => Console.WriteLine($"Message to customer: {message}");
}
