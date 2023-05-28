using Ex32_ObserverPattern2.ConcreteObserver;
using Ex32_ObserverPattern2.Observer;
using Ex32_ObserverPattern2.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_ObserverPattern2.ConcreteSubject
{
    //public class University : Organization, ISubject
    //{
    //    private List<IObserver> teachers = new List<IObserver>();


    //    private string _message;

    //    public string Message
    //    {
    //        get { return _message; }
    //        set { 
    //            _message = value;
    //            Notify();
    //        }
    //    }

    //    public University(string name, string address) : base(name)
    //    {
    //        Address = address;
    //    }

    //    public void Attach(IObserver observer)
    //    {
    //        teachers.Add(observer);
    //    }

    //    public void Detach(IObserver observer)
    //    {
    //        teachers.Remove(observer);
    //        if (observer is Teacher) {
    //            Teacher t = observer as Teacher;
    //            Console.WriteLine($"{t.Name} has been detached...");
    //        }
    //    }

    //    public void Notify()
    //    {
    //        foreach (Teacher teacher in teachers) 
    //        {
    //            Console.WriteLine($"Læreren {teacher.Name} modtog nyheden'{Message}' fra universitetet {Name}");
    //        }
    //    }
    //}
}
