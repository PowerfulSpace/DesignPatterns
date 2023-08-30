using System.Collections;

namespace Pattern_Structural_Composite.ComponentModel.Components
{
    class Composite : Component
    {
        ArrayList nodes = new ArrayList();
        public Composite(string name) : base(name)
        {
        }

        public override void Operations()
        {
            Console.WriteLine(name);
            foreach (Component component in nodes)
            {
                component.Operations();
            }
        }

        public override void Add(Component component)
        {
            nodes.Add(component);
        }

        public override Component GetChild(int index)
        {
            return nodes[index] as Component;
        }
        public override void Remove(Component component)
        {
            nodes.Remove(component);
        }
    }
}
