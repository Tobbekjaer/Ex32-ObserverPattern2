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
        University university;
        public string Message { get; set; }

        public Teacher(University university, string name) : base(name)
        {
            this.university = university;
            this.Message = university.Message; 
        }

        public void Update()
        {
            Message = university.Message; 
        }
    }
}
