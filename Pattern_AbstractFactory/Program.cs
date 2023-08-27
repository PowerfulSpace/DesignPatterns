using Pattern_AbstractFactory.Models;
using Pattern_AbstractFactory.Models.CocaColaModel;
using Pattern_AbstractFactory.Models.PepsiModel;



Client client;

client = new Client(new CocaColaFactory());
client.Run();
Console.WriteLine();
client = new Client(new PepsiFactory());
client.Run();

Console.ReadLine();

