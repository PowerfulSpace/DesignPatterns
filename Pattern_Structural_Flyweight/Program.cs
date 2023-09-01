
using Pattern_Structural_Flyweight.Variant1.Actors;
using Pattern_Structural_Flyweight.Variant1.Roles;

Actor actor = new Actor();

RoleA roleA = new RoleA(actor);
roleA.Greeting("hello i'm A");

RoleB roleB = new RoleB(actor);
roleA.Greeting("hello i'm B");

RoleC roleC = new RoleC(actor);
roleA.Greeting("hello i'm C");

Console.ReadLine();

