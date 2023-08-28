using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models.SchweppesModel
{
    class SchweppesFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new SchweppesBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new SchweppesCover();
        }

        public override AbstractSticker CreateSticker()
        {
            return new SchweppesSticker();
        }

        public override AbstractWater CreateWater()
        {
            return new SchweppesWater();
        }

        public override string ToString()
        {
            return "SchweppesFactory";
        }
    }
}
