namespace Pattern_Structural_Flyweight.Variant1.Roles
{
    class RoleC : FlyWeight
    {
        FlyWeight flyWeight;
        public RoleC(FlyWeight flyWeight)
        {
            this.flyWeight = flyWeight;
        }
        public override void Greeting(string speesh)
        {
            this.flyWeight.Greeting(speesh);
        }
    }
}
