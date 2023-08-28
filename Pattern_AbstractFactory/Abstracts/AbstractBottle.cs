namespace Pattern_AbstractFactory.Abstracts
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
        public abstract void ScrewTheCork(AbstractCover cover);
        public abstract void StickASticker(AbstractSticker  sticker);
    }
}
