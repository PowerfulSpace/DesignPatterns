namespace Pattern_AbstractFactory.Abstracts
{
    abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractWater CreateWater();
        public abstract AbstractCover CreateCover();
        public abstract AbstractSticker CreateSticker();
    }
}
