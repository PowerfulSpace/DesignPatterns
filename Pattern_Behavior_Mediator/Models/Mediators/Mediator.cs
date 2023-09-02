using Pattern_Behavior_Mediator.Models.Colleagues;

namespace Pattern_Behavior_Mediator.Models.Mediators
{
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
