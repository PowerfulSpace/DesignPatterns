using Pattern_Behavior_Visitor.Models.Visitors;

namespace Pattern_Behavior_Visitor.Models.Elements
{
    abstract class Element
    {
        public abstract void Invite(Visitor visitor);
    }
}
