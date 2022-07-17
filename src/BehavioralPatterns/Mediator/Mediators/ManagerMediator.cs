using Mediator.Collegues;

namespace Mediator.Mediators;

internal class ManagerMediator : Mediator
{
      internal Collegue? Customer { get; set; }
      internal Collegue? Programmer { get; set; }
      internal Collegue? Tester { get; set; }

      internal override void Send(string message, Collegue collegue)
      {
            if (collegue == Customer)
            {
                  Programmer?.Notify(message);
                  return;
            }

            if (collegue == Programmer)
            {
                  Tester?.Notify(message);
                  return;
            }

            if (collegue == Tester)
            {
                  Customer?.Notify(message);
                  return;
            }
      }
}
