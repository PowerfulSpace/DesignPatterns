using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models
{
    class Client
    {
        private AbstractWater abstractWater;
        private AbstractBottle abstractBottle;
        private AbstractCover abstractCover;
        private AbstractSticker abstractSticker;
        public Client(AbstractFactory factory)
        {
            abstractWater = factory.CreateWater();
            abstractBottle = factory.CreateBottle();
            abstractCover = factory.CreateCover();
            abstractSticker = factory.CreateSticker();
        }
        public void Run()
        {
            abstractBottle.Interact(abstractWater);
            abstractBottle.ScrewTheCork(abstractCover);
            abstractBottle.StickASticker(abstractSticker);
        }
    }
}
