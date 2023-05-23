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
        Academy academy;
        public string Message { get; set; }
        public Student(Academy academy, string name) : base(name)
        {
            this.academy = academy;
            Message = academy.Message;
        }
       
        public void Update()
        {
           Message = academy.Message;
        }
    }
}
