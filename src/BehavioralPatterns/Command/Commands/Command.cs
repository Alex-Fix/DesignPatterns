namespace Command.Commands;

internal abstract class Command
{
      internal abstract void Execute();
      internal abstract void Undo();
}
