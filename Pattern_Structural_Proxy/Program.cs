

using Pattern_Structural_Proxy.Interfaces;
using Pattern_Structural_Proxy.Models;

IHuman @operator = new Operator();
IHuman surogat = new Surrogate(@operator);
surogat.Request();

Console.ReadLine();