
using System.Collections;

ConcreteSubject subject = new ConcreteSubject();
subject.State = "Some State";

ConcreteObserver concreteObserver1 = new ConcreteObserver(subject);
ConcreteObserver concreteObserver2 = new ConcreteObserver(subject);

subject.Attach(concreteObserver1);
subject.Attach(concreteObserver2);

subject.Notify();

Console.WriteLine(concreteObserver1);
Console.WriteLine(concreteObserver2);

subject.State = "Other State";
subject.Notify();

Console.WriteLine(concreteObserver1);
Console.WriteLine(concreteObserver2);

Console.ReadLine();



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
class ConcreteSubject : Subject
{
    public override string State { get; set; }
}

abstract class Observer
{
    public abstract void Update(string state);
}
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
