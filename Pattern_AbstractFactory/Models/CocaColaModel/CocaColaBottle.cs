using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models.CocaColaModel
{
    class CocaColaBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interact with " + water);
        }
        public override void ScrewTheCork(AbstractCover cover)
        {
            Console.WriteLine(this + " Cover installed " + cover);
        }
    }
}
