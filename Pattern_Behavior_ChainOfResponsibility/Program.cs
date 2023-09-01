

using Pattern_Behavior_ChainOfResponsibility.Models.Handlers;
using Pattern_Behavior_ChainOfResponsibility.Models;

Handler a = new ConcreteHandler1();
Handler b = new ConcreteHandler2();

a.Successor = b;
a.HandleRequest(1);
a.HandleRequest(2);
a.HandleRequest(3);
a.HandleRequest(4);
a.HandleRequest(5);

Console.ReadLine();