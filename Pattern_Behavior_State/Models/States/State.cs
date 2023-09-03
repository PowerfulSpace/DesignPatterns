namespace Pattern_Behavior_State.Models.States
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}
