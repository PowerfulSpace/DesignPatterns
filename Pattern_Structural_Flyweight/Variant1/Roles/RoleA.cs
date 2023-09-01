namespace Pattern_Structural_Flyweight.Variant1.Roles
{
    class RoleA : FlyWeight
    {
        FlyWeight flyWeight;
        public RoleA(FlyWeight flyWeight)
        {
            this.flyWeight = flyWeight;
        }
        public override void Greeting(string speesh)
        {
            this.flyWeight.Greeting(speesh);
        }
    }
}
