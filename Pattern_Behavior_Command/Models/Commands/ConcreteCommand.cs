namespace Pattern_Behavior_Command.Models.Commands
{
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
}
