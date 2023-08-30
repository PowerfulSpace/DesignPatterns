

using Pattern_Structural_Bridge.AbstractionModel;
using Pattern_Structural_Bridge.ImplementationModel;

Abstraction abstraction;

abstraction = new RefineAbstraction(new ConcreteImplementorA());
abstraction.Method();

abstraction = new RefineAbstraction(new ConcreteImplementorB());
abstraction.Method();

Console.ReadLine();