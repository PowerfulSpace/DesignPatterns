

Component component = new ConcreteComponent();

Decorator decoratorA = new ConcreteDecoratorA();
Decorator decoratorB = new ConcreteDecoratorB();

decoratorA.Component = component;
decoratorB.Component = decoratorA;
decoratorB.Operation();


Console.ReadLine();


abstract class Component
{
    public abstract void Operation();
}
class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent");
    }
}

abstract class Decorator : Component
{
    public Component Component { protected get; set; }
    public override void Operation()
    {
        if (Component != null)
            Component.Operation();
    }
}

class ConcreteDecoratorA : Decorator
{
    public string state = "Some state";
    public override void Operation()
    {
        base.Operation();
        Console.WriteLine(state);
    }
}
class ConcreteDecoratorB : Decorator
{
    public void AddedBehavior()
    {
        Console.WriteLine("Behavior");
    }
    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
    }
}

