
using System.Collections;

Village village = new Village();
village.Add(new BoysHouse());
village.Add(new GirlHouse());

village.Accept(new Santa());

Console.ReadLine();



class Village
{
    ArrayList elements = new ArrayList();

    public void Add(Element unit)
    {
        elements.Add(unit);
    }
    public void Remove(Element unit)
    {
        elements.Remove(unit);
    }
    public void Accept(Visitor visitor)
    {
        foreach (Element unit in elements)
        {
            unit.Invite(visitor);
        }
    }
}

abstract class Visitor
{
    public abstract void VisitBoysHouse(BoysHouse boysHouse);
    public abstract void VisitGirlHouse(GirlHouse girlHouse);
}
class Santa : Visitor
{
    public override void VisitBoysHouse(BoysHouse boysHouse)
    {
        boysHouse.TellFairyTale();
    }

    public override void VisitGirlHouse(GirlHouse girlHouse)
    {
        girlHouse.GiveDress();
    }
}
class Troll : Visitor
{
    public override void VisitBoysHouse(BoysHouse boysHouse)
    {
        Console.WriteLine("Украсть подарок у мальчика");
    }

    public override void VisitGirlHouse(GirlHouse girlHouse)
    {
        Console.WriteLine("Украсть подарок у девочки");
    }
}
abstract class Element
{
    public abstract void Invite(Visitor visitor);
}
class BoysHouse : Element
{
    public override void Invite(Visitor visitor)
    {
        if (visitor is Santa)
        {
            visitor.VisitBoysHouse(this);
        }
    }
    public void TellFairyTale()
    {
        Console.WriteLine("Рассказать сказку");
    }
}
class GirlHouse : Element
{
    public override void Invite(Visitor visitor)
    {
        if (visitor is Santa)
        {
            visitor.VisitGirlHouse(this);
        }
    }
    public void GiveDress()
    {
        Console.WriteLine("Подарить платье");
    }
}