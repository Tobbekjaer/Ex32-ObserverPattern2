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
    public delegate void UniversityMessageChanged();

    public class University : Organization
    {
        // Implementing OnMessageChanged delegate to handle notifications
        public UniversityMessageChanged MessageChanged;

        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                // Run MessageChanged delegate to notify all attached observers
                // By calling MessageChanged it's calling all attached methods at once
                MessageChanged();
            }
        }

        public University(string name, string address) : base(name)
        {
            Address = address;
        }

        public void Notify()
        {
            // Run MessageChanged delegate to notify all attached observers
            // By calling MessageChanged it's calling all attached methods at once
            MessageChanged();
        }
    }
}
