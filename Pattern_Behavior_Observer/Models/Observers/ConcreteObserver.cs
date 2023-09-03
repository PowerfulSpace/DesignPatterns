using Pattern_Behavior_Observer.Models.Subjects;

namespace Pattern_Behavior_Observer.Models.Observers
{
    class ConcreteObserver : Observer
    {
        ConcreteSubject subject;
        string observerstate;
        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update(string state)
        {
            observerstate = state;
        }

        public override string ToString()
        {
            return $"подписка: " + observerstate;
        }
    }
}
