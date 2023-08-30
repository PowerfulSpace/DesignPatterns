namespace Pattern_Structural_Composite.ComponentModel.Components
{
    class Left : Component
    {
        public Left(string name) : base(name)
        {
        }

        public override void Operations()
        {
            Console.WriteLine(name);
        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }
        public override void Remove(Component component)
        {
            throw new InvalidOperationException();
        }
    }
}
