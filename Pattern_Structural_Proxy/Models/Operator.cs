using Pattern_Structural_Proxy.Interfaces;

namespace Pattern_Structural_Proxy.Models
{
    class Operator : IHuman
    {
        public void Request()
        {
            Console.WriteLine("Hello");
        }
    }
}
