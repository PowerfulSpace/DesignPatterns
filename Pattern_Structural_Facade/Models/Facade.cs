﻿using Pattern_Structural_Facade.Models.SubSystems;

namespace Pattern_Structural_Facade.Models
{
    class Facade
    {
        SubSystemA subSystemA = new SubSystemA();
        SubSystemB subSystemB = new SubSystemB();
        SubSystemC subSystemC = new SubSystemC();

        public void OperationAB()
        {
            subSystemA.OperationA();
            subSystemB.OperationB();
        }
        public void OperationBC()
        {
            subSystemB.OperationB();
            subSystemC.OperationC();
        }
    }
}
