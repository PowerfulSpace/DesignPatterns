using Pattern_Behavior_Visitor.Models.Elements;
using Pattern_Behavior_Visitor.Models.Visitors;
using System.Collections;

namespace Pattern_Behavior_Visitor.Models
{
    class Village
    {
        ArrayList elements = new ArrayList();

        public void Add(Element unit)
        {
            elements.Add(unit);
        }
        public void Remove(Element unit)
        {
            elements.Remove(unit);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Element unit in elements)
            {
                unit.Invite(visitor);
            }
        }
    }
}
