

Actor actor = new Actor();

RoleA roleA = new RoleA(actor);
roleA.Greeting("hello i'm A");

RoleB roleB = new RoleB(actor);
roleA.Greeting("hello i'm B");

RoleC roleC = new RoleC(actor);
roleA.Greeting("hello i'm C");

Console.ReadLine();

abstract class FlyWeight
{
    public abstract void Greeting(string speesh);
}
class Actor : FlyWeight
{
    public override void Greeting(string speesh)
    {
        Console.WriteLine(speesh);
    }
}
class RoleA : FlyWeight
{
    FlyWeight flyWeight;
    public RoleA(FlyWeight flyWeight)
    {
        this.flyWeight = flyWeight;
    }
    public override void Greeting(string speesh)
    {
        this.flyWeight.Greeting(speesh);
    }
}
class RoleB : FlyWeight
{
    FlyWeight flyWeight;
    public RoleB(FlyWeight flyWeight)
    {
        this.flyWeight = flyWeight;
    }
    public override void Greeting(string speesh)
    {
        this.flyWeight.Greeting(speesh);
    }
}
class RoleC : FlyWeight
{
    FlyWeight flyWeight;
    public RoleC(FlyWeight flyWeight)
    {
        this.flyWeight = flyWeight;
    }
    public override void Greeting(string speesh)
    {
        this.flyWeight.Greeting(speesh);
    }
}