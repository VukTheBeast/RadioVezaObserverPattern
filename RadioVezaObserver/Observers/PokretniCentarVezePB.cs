using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadioVezaObserver.Interfaces;

namespace RadioVezaObserver.Observers
{
    class PokretniCentarVezePB : IObserver, IDisplay
    {
        private int brojProtivnickihVojnika;
        private int brojOMV;
        private ISubject scv;

        public PokretniCentarVezePB(ISubject s)
        {
            this.scv = s;
            this.scv.registerObserver(this);
        }

        public void update(int brojProtivnickihVojnika, int brojOMV, double indexJacine)
        {
            this.brojProtivnickihVojnika = brojProtivnickihVojnika;
            this.brojOMV = brojOMV;
            display();
        }

        public void display()
        {
            Console.WriteLine("PB: brojProticnickihVojnika: {0} , broj Oklopnih motornih vozila: {1}", this.brojProtivnickihVojnika,this.brojOMV); 
        }
    }
}
