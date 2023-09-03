
using Pattern_Behavior_Observer.Models.Observers;
using Pattern_Behavior_Observer.Models.Subjects;

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