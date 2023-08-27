

Client client;

client = new Client(new CocaColaFactory());
client.Run();

client = new Client(new PepsiFactory());
client.Run();

Console.ReadLine();

class Client
{
    private AbstractWater abstractWater;
    private AbstractBottle abstractBottle;
    public Client(AbstractFactory factory)
    {
        abstractWater = factory.CreateWater();
        abstractBottle = factory.CreateBottle();
    }
    public void Run()
    {
        abstractBottle.Interact(abstractWater);
    }
}

abstract class AbstractFactory
{
    public abstract AbstractBottle CreateBottle();
    public abstract AbstractWater CreateWater();
}

class CocaColaFactory : AbstractFactory
{
    public override AbstractBottle CreateBottle()
    {
        return new CocaColaBottle();
    }
    public override AbstractWater CreateWater()
    {
        return new CocaColaWater();
    }
}
class PepsiFactory : AbstractFactory
{
    public override AbstractBottle CreateBottle()
    {
        return new PepsiBottle();
    }
    public override AbstractWater CreateWater()
    {
        return new PepsiWater();
    }
}
abstract class AbstractWater
{

}
abstract class AbstractBottle
{
    public abstract void Interact(AbstractWater water);
}

class CocaColaWater : AbstractWater
{

}
class PepsiWater : AbstractWater
{

}
class CocaColaBottle : AbstractBottle
{
    public override void Interact(AbstractWater water)
    {
        Console.WriteLine(this + " interact with " + water);
    }
}
class PepsiBottle : AbstractBottle
{
    public override void Interact(AbstractWater water)
    {
        Console.WriteLine(this + " interact with " + water);
    }
}