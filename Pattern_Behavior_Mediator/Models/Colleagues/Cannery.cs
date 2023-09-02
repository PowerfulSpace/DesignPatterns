using Pattern_Behavior_Mediator.Models.Mediators;

namespace Pattern_Behavior_Mediator.Models.Colleagues
{
    class Cannery : Colleague
    {
        public Cannery(Mediator mediatr) : base(mediatr) { }
        public void MakeKetchup(string message)
        {
            string ketchup = message + " ketchup";
            Console.WriteLine(this.GetType().Name + " raised " + ketchup);
            mediatr.Send(ketchup, this);
        }
    }
}
