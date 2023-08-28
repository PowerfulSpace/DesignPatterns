


using Pattern_FactoryMethod.Model.CreatorModel;
using Pattern_FactoryMethod.Model;

Creator creator = null!;
Product product = null!;

creator = new ConcreteCreator();
product = creator.FactoryMethod();

Console.WriteLine(product);

Console.ReadLine();