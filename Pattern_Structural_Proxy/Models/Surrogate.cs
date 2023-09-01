using Pattern_Structural_Proxy.Interfaces;

namespace Pattern_Structural_Proxy.Models
{
    class Surrogate : IHuman
    {
        IHuman operatot;
        public Surrogate(IHuman operatot)
        {
            this.operatot = operatot;
        }
        public void Request()
        {
            this.operatot.Request();
        }
    }
}
