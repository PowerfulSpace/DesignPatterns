
using Pattern_Structural_Composite.ComponentModel;
using Pattern_Structural_Composite.ComponentModel.Components;

Component root = new Composite("root");
Component branch1 = new Composite("branch1");
Component branch2 = new Composite("branch2");
Component left1 = new Left("left1");
Component left2 = new Left("left2");

root.Add(branch1);
root.Add(branch2);
branch1.Add(left1);
branch2.Add(left2);

root.Operations();

Console.ReadLine();
