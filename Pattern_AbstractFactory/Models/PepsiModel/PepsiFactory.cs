using Pattern_AbstractFactory.Abstracts;
using Pattern_AbstractFactory.Models.CocaColaModel;

namespace Pattern_AbstractFactory.Models.PepsiModel
{
    class PepsiFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
        public override AbstractCover CreateCover()
        {
            return new PepsiCover();
        }
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }
    }
}
