using Pattern_Behavior_Visitor.Models.Elements;

namespace Pattern_Behavior_Visitor.Models.Visitors
{
    class Santa : Visitor
    {
        public override void VisitBoysHouse(BoysHouse boysHouse)
        {
            boysHouse.TellFairyTale();
        }

        public override void VisitGirlHouse(GirlHouse girlHouse)
        {
            girlHouse.GiveDress();
        }
    }
}
