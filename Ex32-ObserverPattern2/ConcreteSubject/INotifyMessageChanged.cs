using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_ObserverPattern2.ConcreteSubject
{
    public interface INotifyMessageChanged
    {
        // MessageChanged event af typen EventHandler
        public event EventHandler MessageChanged;
    }
}
