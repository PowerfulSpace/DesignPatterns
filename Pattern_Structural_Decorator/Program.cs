

using Pattern_Structural_Decorator.Model.Components;
using Pattern_Structural_Decorator.Model.Decorators;

Component component = new ConcreteComponent();

Decorator decoratorA = new ConcreteDecoratorA();
Decorator decoratorB = new ConcreteDecoratorB();

decoratorA.Component = component;
decoratorB.Component = decoratorA;
decoratorB.Operation();


Console.ReadLine();
