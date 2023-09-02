using Pattern_Behavior_Mediator.Models.Mediators;

namespace Pattern_Behavior_Mediator.Models.Colleagues
{
    abstract class Colleague
    {
        protected Mediator mediatr;
        public Colleague(Mediator mediatr)
        {
            this.mediatr = mediatr;
        }
    }
}
