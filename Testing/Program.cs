

Creator creator = null!;
Product product = null!;

creator = new ConcreteCreator();
product = creator.FactoryMethod();

Console.WriteLine(product);

Console.ReadLine();



abstract class Product
{

}
class ConcreteProduct : Product
{
    public ConcreteProduct()
    {
        Console.WriteLine(this.GetHashCode());
    }
}

abstract class Creator
{
    Product product;
    public abstract Product FactoryMethod();
}
class ConcreteCreator : Creator
{
    public override Product FactoryMethod()
    {
        return new ConcreteProduct();
    }
}