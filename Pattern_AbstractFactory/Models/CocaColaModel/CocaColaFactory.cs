﻿using Pattern_AbstractFactory.Abstracts;

namespace Pattern_AbstractFactory.Models.CocaColaModel
{
    class CocaColaFactory : AbstractFactory
    {
        public override AbstractBottle CreateBottle()
        {
            return new CocaColaBottle();
        }

        public override AbstractCover CreateCover()
        {
            return new CocaColaCover();
        }

        public override AbstractSticker CreateSticker()
        {
            return new CocaColaSticker();
        }

        public override AbstractWater CreateWater()
        {
            return new CocaColaWater();
        }

        public override string ToString()
        {
            return "CocaColaFactory";
        }
    }
}
