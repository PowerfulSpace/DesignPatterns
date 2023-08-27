using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models.CocaColaModel
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }
        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }
    }
}
