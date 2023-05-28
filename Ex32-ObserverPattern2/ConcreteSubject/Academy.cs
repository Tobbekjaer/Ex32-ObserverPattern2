using Ex32_ObserverPattern2.ConcreteObserver;
using Ex32_ObserverPattern2.Observer;
using Ex32_ObserverPattern2.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex32_ObserverPattern2.ConcreteSubject
{
    public delegate void NotifyHandler();
    public class Academy : Organization, ISubject
    {
        private NotifyHandler students;

        private string message;

        public string Message
        {
            get { return message; }
            set {
                message = value;
                Notify();
            }
        }

        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        public void Attach(IObserver observer)
        {
            students += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            students -= observer.Update;
        }

        public void Notify()
        {
            students();
        }



    }
}
