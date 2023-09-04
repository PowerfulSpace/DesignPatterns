using Pattern_Behavior_Visitor.Models.Visitors;

namespace Pattern_Behavior_Visitor.Models.Elements
{
    class GirlHouse : Element
    {
        public override void Invite(Visitor visitor)
        {
            if (visitor is Santa)
            {
                visitor.VisitGirlHouse(this);
            }
        }
        public void GiveDress()
        {
            Console.WriteLine("Подарить платье девочке");
        }
    }
}
