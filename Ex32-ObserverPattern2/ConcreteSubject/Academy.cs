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
    public delegate void EventHandler(object sender, EventArgs e);
    public class Academy : Organization, INotifyMessageChanged
    {
        // Instans af MessageChanged eventet
        public event EventHandler MessageChanged;
        
        private string message;

        public string Message
        {
            get { return message; }
            set {
                if(message != value) {
                    message = value;
                    // Kalder OnMessageChanged, når Message bliver ændret
                    OnMessageChanged();
                }
              
            }
        }

        public Academy(string name, string address) : base(name)
        {
            Address = address;
        }

        // OnMessageChanged metoden skal have kaldet til MessageChanged eventet have to parametre
        // sender: objektet, der rejser eventet (academy instansen) og e: evt. yderligere data (sæt til null i dette tilfælde)
        // OnMessageChanged sender beskeder til alle, der abbonnere på eventet MessageChanged (defineres i Main)
        public void OnMessageChanged()
        {
            if (MessageChanged != null) {
                MessageChanged(this, EventArgs.Empty);
            }
        }
    }

}
