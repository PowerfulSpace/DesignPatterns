namespace Pattern_Structural_Decorator.Model.Decorators
{
    class ConcreteDecoratorB : Decorator
    {
        public void AddedBehavior()
        {
            Console.WriteLine("Behavior");
        }
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}
