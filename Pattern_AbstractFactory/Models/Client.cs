using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models
{
    class Client
    {
        private AbstractWater abstractWater;
        private AbstractBottle abstractBottle;
        public Client(AbstractFactory factory)
        {
            abstractWater = factory.CreateWater();
            abstractBottle = factory.CreateBottle();
        }
        public void Run()
        {
            abstractBottle.Interact(abstractWater);
        }
    }
}
