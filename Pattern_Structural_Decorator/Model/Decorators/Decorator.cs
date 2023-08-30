using Pattern_Structural_Decorator.Model.Components;

namespace Pattern_Structural_Decorator.Model.Decorators
{
    abstract class Decorator : Component
    {
        public Component Component { protected get; set; }
        public override void Operation()
        {
            if (Component != null)
                Component.Operation();
        }
    }
}
