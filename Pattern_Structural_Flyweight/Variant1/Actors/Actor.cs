namespace Pattern_Structural_Flyweight.Variant1.Actors
{
    class Actor : FlyWeight
    {
        public override void Greeting(string speesh)
        {
            Console.WriteLine(speesh);
        }
    }
}
