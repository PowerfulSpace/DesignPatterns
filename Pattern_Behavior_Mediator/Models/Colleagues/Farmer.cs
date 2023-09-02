using Pattern_Behavior_Mediator.Models.Mediators;

namespace Pattern_Behavior_Mediator.Models.Colleagues
{
    class Farmer : Colleague
    {
        public Farmer(Mediator mediatr) : base(mediatr) { }
        public void GrowTomato()
        {
            string tomato = "Tomato";
            Console.WriteLine(this.GetType().Name + " raised " + tomato);
            mediatr.Send(tomato, this);
        }

    }
}
