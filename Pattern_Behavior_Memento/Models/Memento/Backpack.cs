namespace Pattern_Behavior_Memento.Models.Memento
{
    class Backpack
    {
        public string Contents { get; private set; }
        public Backpack(string state)
        {
            Contents = state;
        }
    }
}
