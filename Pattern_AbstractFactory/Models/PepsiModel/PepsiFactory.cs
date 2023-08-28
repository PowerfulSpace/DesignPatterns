using Pattern_AbstractFactory.Abstracts;

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
        public override AbstractSticker CreateSticker()
        {
            return new PepsiSticker();
        }
        public override string ToString()
        {
            return "PepsiFactory";
        }
    }
}
