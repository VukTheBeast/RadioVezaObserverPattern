using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RadioVezaObserver.Interfaces;

namespace RadioVezaObserver.Observers
{
    class PokretniCVAB : IObserver, IDisplay
    {
        private int brojOMV;
        private ISubject scv;

        public PokretniCVAB(ISubject s)
        {
            this.scv = s;
            this.scv.registerObserver(this);
        }
        public void update(int brojProtivnickihVojnika, int brojOMV, double indexJacine)
        {
            this.brojOMV = brojOMV;
            display();
        }

        public void display()
        {
            Console.WriteLine("Porketni Artiljeriski Bataljon : broj Oklopnih vozila : " + this.brojOMV);
        }
    }
}
