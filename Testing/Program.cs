

var a = Singleton.Instance();
var b = Singleton.Instance();

Console.WriteLine(a == b);
Console.WriteLine(ReferenceEquals(a,b));

Console.WriteLine(a.Equals(b));


Console.ReadLine();



class Singleton
{
    static private Singleton uniqueInstance;
    protected Singleton()
    {
    }
    static public Singleton Instance()
    {
        if (uniqueInstance == null)
        {
            uniqueInstance = new Singleton();
        }
        return uniqueInstance;
    }
}

