namespace Pattern_AbstractFactory.Abstracts
{
    abstract class AbstractFactory
    {
        public abstract AbstractBottle CreateBottle();
        public abstract AbstractWater CreateWater();
    }
}
