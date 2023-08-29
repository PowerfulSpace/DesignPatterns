
using Pattern_Singleton;

var a = Singleton.Instance();
var b = Singleton.Instance();

Console.WriteLine(a == b);
Console.WriteLine(ReferenceEquals(a, b));

Console.WriteLine(a.Equals(b));


Console.ReadLine();