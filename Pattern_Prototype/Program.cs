

using Pattern_Prototype.Model.PrototypeModel;
using Pattern_Prototype.Model;

Prototype prototype = null!;
Prototype clone = null!;

prototype = new ConcretePrototype1(1);
clone = prototype.Clone();

prototype = new ConcretePrototype2(2);
clone = prototype.Clone();

Console.ReadLine();