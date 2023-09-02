using Pattern_Behavior_Command.Models.Commands;

namespace Pattern_Behavior_Command.Models
{
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
}
