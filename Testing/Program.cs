
IHuman @operator = new Operator();
IHuman surogat = new Surrogate(@operator);
surogat.Request();

Console.ReadLine();



interface IHuman
{
    void Request();
}

class Operator : IHuman
{
    public void Request()
    {
        Console.WriteLine("Hello");
    }
}
class Surrogate : IHuman
{
    IHuman operatot;
    public Surrogate(IHuman operatot)
    {
        this.operatot = operatot;
    }
    public void Request()
    {
        this.operatot.Request();
    }
}