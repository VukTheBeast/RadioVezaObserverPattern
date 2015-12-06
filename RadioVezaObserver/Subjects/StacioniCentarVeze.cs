using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadioVezaObserver.Interfaces;

namespace RadioVezaObserver.Interfaces
{
    class StacioniCentarVeze : ISubject
    {
        private List<IObserver> observers;
        private int brojProtivnickihVojnika;
        private int brojOMV;
        private double indexJacine;

        public StacioniCentarVeze()
        {
            observers = new List<IObserver>();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void deleteObserver(IObserver o)
        {
            int ind = observers.IndexOf(o);
            if (ind >= 0)
            {
                observers.Remove(o);
            }
            
        }

        public void notifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.update(brojProtivnickihVojnika, brojOMV, indexJacine);
            }
        }

        public void promenaStanja()
        {
            notifyObservers();
        }

        public void postaviPodatke(int brojProtivnickihVojnika, int brojOMV, double indexJacine)
        {
            this.brojProtivnickihVojnika = brojProtivnickihVojnika;
            this.brojOMV = brojOMV;
            this.indexJacine = indexJacine;

            promenaStanja();
        }
    }
}
