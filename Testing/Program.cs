
Receiver receiver = new Receiver();
Command command = new ConcreteCommand(receiver);
Invoke invoke = new Invoke();

invoke.StoreCommand(command);
invoke.ExecuteCommand();

Console.ReadLine();


class Receiver
{
    public void Action()
    {
        Console.WriteLine("Action");
    }
}

abstract class Command
{
    protected Receiver receiver;
    public Command(Receiver receiver)
    {
        this.receiver = receiver;
    }
    public abstract void Execute();
}

class ConcreteCommand : Command
{
    public ConcreteCommand(Receiver receiver) : base(receiver) 
    {
    }
    public override void Execute()
    {
        receiver.Action();
    }
}

class Invoke
{
    public Command command;
    public void ExecuteCommand()
    {
        command.Execute();
    }
    public void StoreCommand(Command command)
    {
        this.command = command;
    }
}