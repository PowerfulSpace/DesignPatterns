

using Pattern_Behavior_State.Models.States;
using Pattern_Behavior_State.Models;

Context context = new Context(new ConcreteStateA());
context.Request();
Console.WriteLine(context.State);
context.Request();
Console.WriteLine(context.State);
context.Request();
Console.WriteLine(context.State);
context.Request();
Console.WriteLine(context.State);

Console.ReadLine();