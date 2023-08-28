using Pattern_AbstractFactory.Models;
using Pattern_AbstractFactory.Models.CocaColaModel;
using Pattern_AbstractFactory.Models.PepsiModel;
using Pattern_AbstractFactory.Models.SchweppesModel;

Client client;

client = new Client(new CocaColaFactory());
client.Run();
Console.WriteLine();
client = new Client(new PepsiFactory());
client.Run();
Console.WriteLine();
client = new Client(new SchweppesFactory());
client.Run();

Console.ReadLine();

