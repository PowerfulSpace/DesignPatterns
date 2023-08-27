using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models.PepsiModel
{
    class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interact with " + water);
        }
    }
}
