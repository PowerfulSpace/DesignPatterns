namespace Pattern_Structural_Flyweight.Variant2
{
    //public class FlyWeight_Variant2
    //{
    //    public void Main()
    //    {
    //        int extrinsicState = 0;

    //        Flyweight flyweight = null;
    //        FlyweightFactory factory = new FlyweightFactory();

    //        flyweight = factory.GetFlyweight("1");
    //        flyweight.Operation(extrinsicState);

    //        flyweight = factory.GetFlyweight("10");
    //        flyweight.Operation(extrinsicState);

    //        flyweight = new UnSharedConcreteFlyweight();
    //        flyweight.Operation(extrinsicState);

    //        Console.ReadLine();

    //    }
    //}

    //abstract class Flyweight
    //{
    //    public abstract void Operation(int extrinsicState);
    //}

    //class FlyweightFactory
    //{
    //    Hashtable table = new Hashtable()
    //{
    //    {"1", new ConcreteFlyweight()},
    //    {"2", new ConcreteFlyweight()},
    //    {"3", new ConcreteFlyweight()}
    //};

    //    public Flyweight GetFlyweight(string key)
    //    {
    //        if (!table.ContainsKey(key))
    //        {
    //            table.Add(key, new ConcreteFlyweight());
    //        }

    //        return table[key] as Flyweight;
    //    }
    //}

    //class ConcreteFlyweight : Flyweight
    //{
    //    int itrinsicState;
    //    public override void Operation(int extrinsicState)
    //    {
    //        itrinsicState = extrinsicState;
    //    }
    //}

    //class UnSharedConcreteFlyweight : Flyweight
    //{
    //    int allState;
    //    public override void Operation(int extrinsicState)
    //    {
    //        allState = extrinsicState;
    //    }
    //}
}

