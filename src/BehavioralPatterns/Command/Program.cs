using Command;
using C = Command.Commands;

Receiver receiver = new();
C.Command command = new C.ConcreteCommand(receiver);

Invoker invoker = new();
invoker.SetCommand(command);
invoker.Run();