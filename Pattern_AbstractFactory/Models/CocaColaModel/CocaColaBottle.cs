﻿using Pattern_AbstractFactory.Abstracts;

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

        public override void StickASticker(AbstractSticker sticker)
        {
            Console.WriteLine(this + " sticker pasted " + sticker);
        }

        public override string ToString()
        {
            return "CocaColaBottle";
        }
    }
}
