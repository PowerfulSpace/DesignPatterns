
Handler a = new ConcreteHandler1();
Handler b = new ConcreteHandler2();

a.Successor = b;
a.HandleRequest(1);
a.HandleRequest(2);
a.HandleRequest(3);
a.HandleRequest(4);
a.HandleRequest(5);

Console.ReadLine();


abstract class Handler
{
    public Handler Successor { get; set; }
    public abstract void HandleRequest(int request);
}

class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request == 1)
        {
            Console.WriteLine("ConcreteHandler1");
        }
        else if(Successor != null)
        {
            this.Successor.HandleRequest(request);
        }
    }
}
class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request ==2 )
        {
            Console.WriteLine("ConcreteHandler2");
        }
        else if (Successor != null)
        {
            this.Successor.HandleRequest(request);
        }
    }
}