

Provider a = new ProviderA();
Provider b = new ProviderB();
Provider c = new Adapter();

a.Request();
b.Request();
c.Request();

Console.WriteLine();

Consumer consumer;
consumer = new Consumer(a);
consumer.Use();
consumer = new Consumer(b);
consumer.Use();
consumer = new Consumer(c);
consumer.Use();

Console.ReadLine();



class Consumer
{
    Provider provider;
    public Consumer(Provider provider)
    {
        this.provider = provider;
    }
    public void Use()
    {
        provider.Request();
    }
}

abstract class Provider
{
    public abstract void Request();
}

class ProviderA : Provider
{
    public override void Request()
    {
        Console.WriteLine("ProviderA");
    }
}
class ProviderB : Provider
{
    public override void Request()
    {
        Console.WriteLine("ProviderB");
    }
}
class Adapter : Provider
{
    SuperProvider superProvider = new SuperProvider();
    public override void Request()
    {
        superProvider.SpecificRequest();
    }
}

class SuperProvider
{
    public void SpecificRequest()
    {
        Console.WriteLine("SuperProvider");
    }
}