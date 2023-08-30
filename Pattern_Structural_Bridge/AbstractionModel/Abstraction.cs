using Pattern_Structural_Bridge.ImplementationModel;

namespace Pattern_Structural_Bridge.AbstractionModel
{
    abstract class Abstraction
    {
        protected Implementor implementor;
        public Abstraction(Implementor implementor)
        {
            this.implementor = implementor;
        }
        public virtual void Method()
        {
            implementor.Operation();
        }
    }
}
