

ConcreteMediatr mediatr = new ConcreteMediatr();

Farmer farmer = new Farmer(mediatr);
Cannery cannery = new Cannery(mediatr);
Shop shop = new Shop(mediatr);


mediatr.Farmer = farmer;
mediatr.Cannery = cannery;
mediatr.Shop = shop;

farmer.GrowTomato();

Console.ReadLine();


abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}
class ConcreteMediatr : Mediator
{
    public Farmer Farmer { get; set; }
    public Cannery Cannery { get; set; }
    public Shop Shop { get; set; }
    public override void Send(string message, Colleague colleague)
    {
        if (colleague == Farmer)
        {
            Cannery.MakeKetchup(message);
        }
        else if (colleague == Cannery)
        {
            Shop.SellKetchup(message);
        }
    }
}

abstract class Colleague
{
    protected Mediator mediatr;
    public Colleague(Mediator mediatr)
    {
        this.mediatr = mediatr;
    }
}
class Farmer : Colleague
{
    public Farmer(Mediator mediatr) : base(mediatr) { }
    public void GrowTomato()
    {
        string tomato = "Tomato";
        Console.WriteLine(this.GetType().Name + " raised " + tomato);
        mediatr.Send(tomato, this);
    }

}
class Cannery : Colleague
{
    public Cannery(Mediator mediatr) : base(mediatr) { }
    public void MakeKetchup(string message)
    {
        string ketchup = message + " ketchup";
        Console.WriteLine(this.GetType().Name + " raised " + ketchup);
        mediatr.Send(ketchup, this);
    }
}
class Shop : Colleague
{
    public Shop(Mediator mediatr) : base(mediatr) { }
    public void SellKetchup(string message)
    {
        Console.WriteLine(this.GetType().Name + " sold " + message);
    }
}