﻿using System.Collections;

namespace Pattern_Builder.Model.HouseModel
{
    class House
    {
        private ArrayList house;
        public House()
        {
            house = new ArrayList();
        }
        public void Add(object obj)
        {
            house.Add(obj);
        }
    }
}
