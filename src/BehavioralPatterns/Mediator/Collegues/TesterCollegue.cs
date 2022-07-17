using M = Mediator.Mediators;

namespace Mediator.Collegues;

internal class TesterCollegue : Collegue
{
      internal TesterCollegue(M.Mediator mediator) : base(mediator)
      {
      }

      internal override void Notify(string message) => Console.WriteLine($"Message to tester: {message}");
}
