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
    public delegate void OnMessageChanged();
    public class Academy : Organization
    {
        public OnMessageChanged MessageChanged;

        private string message;

        public string Message
        {
            get { return message; }
            set {
                message = value;
                MessageChanged();
            }
        }

        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        public void Notify()
        {
            MessageChanged();
        }



    }
}
