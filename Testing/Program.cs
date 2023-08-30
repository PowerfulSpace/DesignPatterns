


using System.Collections;

Component root = new Composite("root");
Component branch1 = new Composite("branch1");
Component branch2 = new Composite("branch2");
Component left1 = new Left("left1");
Component left2 = new Left("left2");

root.Add(branch1);
root.Add(branch2);
branch1.Add(left1);
branch2.Add(left2);

root.Operations();

Console.ReadLine();


abstract class Component
{
    protected string name;
    public Component(string name)
    {
        this.name = name;
    }
    public abstract void Operations();
    public abstract void Add(Component component);
    public abstract void Remove(Component component);
    public abstract Component GetChild(int index);
}
class Composite : Component
{
    ArrayList nodes = new ArrayList();
    public Composite(string name) : base(name)
    {    
    }

    public override void Operations()
    {
        Console.WriteLine(name);
        foreach (Component component in nodes)
        {
            component.Operations();
        }
    }

    public override void Add(Component component)
    {
        nodes.Add(component);
    }

    public override Component GetChild(int index)
    {
        return nodes[index] as Component;
    }
    public override void Remove(Component component)
    {
        nodes.Remove(component);
    }
}
class Left : Component
{
    public Left(string name) : base(name)
    {
    }

    public override void Operations()
    {
        Console.WriteLine(name);
    }

    public override void Add(Component component)
    {
        throw new InvalidOperationException();
    }

    public override Component GetChild(int index)
    {
        throw new InvalidOperationException();
    }
    public override void Remove(Component component)
    {
        throw new InvalidOperationException();
    }
}