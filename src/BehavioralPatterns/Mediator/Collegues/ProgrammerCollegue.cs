using M = Mediator.Mediators;

namespace Mediator.Collegues;

internal class ProgrammerCollegue : Collegue
{
      internal ProgrammerCollegue(M.Mediator mediator) : base(mediator)
      {
      }

      internal override void Notify(string message) => Console.WriteLine($"Message to programmer: {message}");
}
