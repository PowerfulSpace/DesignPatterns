namespace Pattern_Structural_Decorator.Model.Decorators
{
    class ConcreteDecoratorA : Decorator
    {
        public string state = "Some state";
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(state);
        }
    }
}
