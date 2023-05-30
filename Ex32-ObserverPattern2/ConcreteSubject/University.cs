using Ex32_ObserverPattern2.ConcreteObserver;
using Ex32_ObserverPattern2.Observer;
using Ex32_ObserverPattern2.Subject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_ObserverPattern2.ConcreteSubject
{
    public delegate void UniversityMessageChanged();

    public class University : Organization, INotifyPropertyChanged
    {
        // Tilføjet INotifyPropertyChanged eventet, til at notificerer dets abbonnenter, når en Property ændres (fra Main)
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null) propertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        private string _message;

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                //Kalder OnPropertyChanged metoden med navnet på den parameter, der bliver ændret
                OnPropertyChanged("Message");
            }
        }

        public University(string name, string address) : base(name)
        {
            Address = address;
        }

    }
}
