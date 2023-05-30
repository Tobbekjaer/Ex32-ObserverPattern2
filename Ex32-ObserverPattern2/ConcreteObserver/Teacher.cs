using Ex32_ObserverPattern2.ConcreteSubject;
using Ex32_ObserverPattern2.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_ObserverPattern2.ConcreteObserver
{

    public class Teacher : Person, IObserver
    {
        public string Message { get; set; }

        public Teacher(string name) : base(name)
        {

        }

        public void Update(object sender, EventArgs e)
        {
            if (sender is University university) {
                Console.WriteLine($"Læreren {Name} modtog nyheden'{university.Message}' fra universitetet {university.Name}");
            }
        }
    }
}
