using Pattern_Behavior_Visitor.Models.Elements;

namespace Pattern_Behavior_Visitor.Models.Visitors
{
    abstract class Visitor
    {
        public abstract void VisitBoysHouse(BoysHouse boysHouse);
        public abstract void VisitGirlHouse(GirlHouse girlHouse);
    }
}
