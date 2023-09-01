namespace Pattern_Structural_Flyweight.Variant1.Roles
{
    class RoleB : FlyWeight
    {
        FlyWeight flyWeight;
        public RoleB(FlyWeight flyWeight)
        {
            this.flyWeight = flyWeight;
        }
        public override void Greeting(string speesh)
        {
            this.flyWeight.Greeting(speesh);
        }
    }
}
