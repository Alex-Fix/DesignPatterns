namespace Command.Commands;

internal class ConcreteCommand : Command
{
      private readonly Receiver _receiver;

      internal ConcreteCommand(Receiver receiver)
      {
            _receiver = receiver;
      }

      internal override void Execute()
      {
            _receiver.Operation();
      }

      internal override void Undo()
      {
      }
}
