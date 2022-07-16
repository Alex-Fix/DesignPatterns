using C = Command.Commands;

namespace Command;

internal class Invoker
{
      private C.Command? _command;

      internal void SetCommand(C.Command command)
      {
            _command = command;
      }

      internal void Run()
      {
            _command?.Execute();
      }

      internal void Cancel()
      {
            _command?.Undo();
      }
}