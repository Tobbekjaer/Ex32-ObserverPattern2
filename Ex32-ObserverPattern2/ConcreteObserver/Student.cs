using Ex32_ObserverPattern2.ConcreteSubject;
using Ex32_ObserverPattern2.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ex32_ObserverPattern2.ConcreteObserver
{
    public class Student : Person, IObserver
    {
        public string Message { get; set; }

        // Vi har fjernet academy-feltet i Student-klassen og academy parameteren i Constructoren
        // Da MessageChanged eventet også angiver objektet, der rejste eventet (via sender parameteren)
        public Student(string name) : base(name)
        {
           
        }
        
        // Tilrettet Update metoden, så den overholder ændringen af IObserver interfacet
        public void Update(object sender, EventArgs e)
        {
            if (sender is Academy academy) {
                Console.WriteLine($"Studerende {base.Name} modtog nyheden '{academy.Message}' fra akademiet {academy.Name}");
            }
        }

    }

}
