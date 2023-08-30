
Abstraction abstraction;

abstraction = new RefineAbstraction(new ConcreteImplementorA());
abstraction.Method();

abstraction = new RefineAbstraction(new ConcreteImplementorB());
abstraction.Method();

Console.ReadLine();



abstract class Abstraction
{
    protected Implementor implementor;
    public Abstraction(Implementor implementor)
    {
        this.implementor = implementor;
    }
    public virtual void Method()
    {
        implementor.Operation();
    }
}
class RefineAbstraction : Abstraction
{
    public RefineAbstraction(Implementor implementor) : base(implementor)
    {
    }

    public override void Method()
    {
        base.Method();
    }
}
abstract class Implementor
{
    public abstract void Operation();
}
class ConcreteImplementorA : Implementor
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteImplementorA");
    }
}
class ConcreteImplementorB : Implementor
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteImplementorB");
    }
}