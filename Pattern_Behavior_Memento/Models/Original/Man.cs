using Pattern_Behavior_Memento.Models.Memento;

namespace Pattern_Behavior_Memento.Models.Original
{
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
}
