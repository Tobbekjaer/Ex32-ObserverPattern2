using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32_ObserverPattern2.Observer
{
    public interface IObserver
    {
        // Tilretning af IObserver, så Update har samme signatur som EventHandler 
        void Update(object sender, EventArgs e);
    }
}
