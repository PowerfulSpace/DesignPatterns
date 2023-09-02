

using Pattern_Behavior_Command.Models.Commands;
using Pattern_Behavior_Command.Models;

Receiver receiver = new Receiver();
Command command = new ConcreteCommand(receiver);
Invoke invoke = new Invoke();

invoke.StoreCommand(command);
invoke.ExecuteCommand();

Console.ReadLine();