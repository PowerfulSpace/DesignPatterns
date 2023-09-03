using Pattern_Behavior_State.Models.States;

namespace Pattern_Behavior_State.Models
{
    class Context
    {
        public State State { get; set; }

        public Context(State state)
        {
            State = state;
        }
        public void Request()
        {
            State.Handle(this);
        }
    }
}
