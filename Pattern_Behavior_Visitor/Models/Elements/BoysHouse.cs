using Pattern_Behavior_Visitor.Models.Visitors;

namespace Pattern_Behavior_Visitor.Models.Elements
{
    class BoysHouse : Element
    {
        public override void Invite(Visitor visitor)
        {
            if (visitor is Santa)
            {
                visitor.VisitBoysHouse(this);
            }
        }
        public void TellFairyTale()
        {
            Console.WriteLine("Рассказать сказку мальчику");
        }
    }
}
