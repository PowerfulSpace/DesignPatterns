
using System.Collections;

Builder builder = new ConcreteBuilder();
Foreman foreman = new Foreman(builder);
foreman.Construct();
House result = builder.GetResult();

Console.ReadLine();
class Foreman
{
    Builder builder;
    public Foreman(Builder builder)
    {
        this.builder = builder;
    }
    public void Construct()
    {
        builder.CreateBasement();
        builder.CreateStorey();
        builder.CreateRoof();
    }
}
abstract class Builder
{
    public abstract void CreateBasement();
    public abstract void CreateStorey();
    public abstract void CreateRoof();
    public abstract House GetResult();

}
class ConcreteBuilder : Builder 
{
    public House house = new House();
    public override void CreateBasement()
    {
        house.Add(new Basement());
    }
    public override void CreateStorey()
    {
        house.Add(new Storey());
    }
    public override void CreateRoof()
    {
        house.Add(new Roof());
    }
    public override House GetResult()
    {
        return house;
    }
}

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
class Basement
{
    public Basement()
    {
        Console.WriteLine("Подвал построен");
    } 
}
class Storey
{
    public Storey()
    {
        Console.WriteLine("Этаж построен");
    }
}
class Roof
{
    public Roof()
    {
        Console.WriteLine("Крыша построена");
    }
}