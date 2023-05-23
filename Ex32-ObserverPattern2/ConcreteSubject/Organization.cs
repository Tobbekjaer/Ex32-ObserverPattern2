using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_ObserverPattern2.ConcreteSubject
{
    public class Organization
    {
        public string Name { get; }
        public string Address { get; set; }

        public Organization(string name)
        {
            Name = name;
        }
    }
}
