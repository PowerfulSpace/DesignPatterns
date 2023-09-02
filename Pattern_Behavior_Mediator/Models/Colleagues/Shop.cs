using Pattern_Behavior_Mediator.Models.Mediators;

namespace Pattern_Behavior_Mediator.Models.Colleagues
{
    class Shop : Colleague
    {
        public Shop(Mediator mediatr) : base(mediatr) { }
        public void SellKetchup(string message)
        {
            Console.WriteLine(this.GetType().Name + " sold " + message);
        }
    }
}
