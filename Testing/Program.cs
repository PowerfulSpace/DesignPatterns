

Man man = new Man();
Robot robot = new Robot();

man.Clothes = "Джинсы, футболка, кеды";
robot.Backpack = man.UnDress();

man.Clothes = "шорты";

man.Dress(robot.Backpack);

Console.ReadLine();


class Man
{
    public string Clothes { get; set; }
    public void Dress(Backpack backpack)
    {
        Clothes = backpack.Contents;
    }
    public Backpack UnDress()
    {
        return new Backpack(Clothes);
    }
}
class Backpack
{
    public string Contents { get; private set; }
    public Backpack(string state)
    {
        Contents = state;
    }
}
class Robot
{
    public Backpack Backpack { get; set; }
}