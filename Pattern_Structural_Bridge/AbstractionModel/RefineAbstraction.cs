using Pattern_Structural_Bridge.ImplementationModel;

namespace Pattern_Structural_Bridge.AbstractionModel
{
    class RefineAbstraction : Abstraction
    {
        public RefineAbstraction(Implementor implementor) : base(implementor)
        {
        }

        public override void Method()
        {
            base.Method();
        }
    }
}
