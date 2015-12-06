using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadioVezaObserver.Interfaces;

namespace RadioVezaObserver.Interfaces
{
    interface ISubject
    {
        void registerObserver(IObserver o);
        void deleteObserver(IObserver o);
        void notifyObservers();
    }
}
