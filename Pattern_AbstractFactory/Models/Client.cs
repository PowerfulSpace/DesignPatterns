using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models
{
    class Client
    {
        private AbstractWater abstractWater;
        private AbstractBottle abstractBottle;
        private AbstractCover abstractCover;
        public Client(AbstractFactory factory)
        {
            abstractWater = factory.CreateWater();
            abstractBottle = factory.CreateBottle();
            abstractCover = factory.CreateCover();
        }
        public void Run()
        {
            abstractBottle.Interact(abstractWater);
            abstractBottle.ScrewTheCork(abstractCover);
        }
    }
}
