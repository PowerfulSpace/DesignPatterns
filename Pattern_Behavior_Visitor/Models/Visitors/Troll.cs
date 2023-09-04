using Pattern_Behavior_Visitor.Models.Elements;

namespace Pattern_Behavior_Visitor.Models.Visitors
{
    class Troll : Visitor
    {
        public override void VisitBoysHouse(BoysHouse boysHouse)
        {
            Console.WriteLine("Украсть подарок у мальчика");
        }

        public override void VisitGirlHouse(GirlHouse girlHouse)
        {
            Console.WriteLine("Украсть подарок у девочки");
        }
    }
}
