
Facade facade = new Facade();

facade.OperationAB();
Console.WriteLine();
facade.OperationBC();

Console.ReadLine();



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
class SubSystemA
{
    public void OperationA()
    {
        Console.WriteLine("SubSystemA");
    }
}
class SubSystemB
{
    public void OperationB()
    {
        Console.WriteLine("SubSystemB");
    }
}
class SubSystemC
{
    public void OperationC()
    {
        Console.WriteLine("SubSystemC");
    }
}