
using Pattern_Behavior_Visitor.Models;
using Pattern_Behavior_Visitor.Models.Elements;
using Pattern_Behavior_Visitor.Models.Visitors;

Village village = new Village();
village.Add(new BoysHouse());
village.Add(new GirlHouse());

village.Accept(new Santa());

Console.ReadLine();