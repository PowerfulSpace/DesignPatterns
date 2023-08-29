

using Pattern_Structural_Adapter.Model.ProviderModel;
using Pattern_Structural_Adapter.Model;

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