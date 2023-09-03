using Pattern_Behavior_Observer.Models.Observers;
using System.Collections;

namespace Pattern_Behavior_Observer.Models.Subjects
{
    abstract class Subject
    {
        ArrayList observers = new ArrayList();
        public abstract string State { get; set; }
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(State);
            }
        }
    }
}
