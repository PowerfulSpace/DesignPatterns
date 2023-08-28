

using Pattern_Builder.Model.BuilderModel;
using Pattern_Builder.Model.HouseModel;
using Pattern_Builder.Model;

Builder builder = new ConcreteBuilder();
Foreman foreman = new Foreman(builder);
foreman.Construct();
House result = builder.GetResult();

Console.ReadLine();