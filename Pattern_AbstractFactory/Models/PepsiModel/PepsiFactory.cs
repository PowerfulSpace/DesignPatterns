using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models.PepsiModel
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
    }
}
