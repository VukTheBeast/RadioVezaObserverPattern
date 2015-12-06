using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RadioVezaObserver.Observers;
using RadioVezaObserver.Interfaces;


namespace RadioVezaObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            StacioniCentarVeze scv1 = new StacioniCentarVeze();

            PokretniCentarVezePB pb1 = new PokretniCentarVezePB(scv1);
            PokretniCVAB ab1 = new PokretniCVAB(scv1);

            scv1.postaviPodatke(3, 2, 0.2);
            scv1.postaviPodatke(17, 5, 0.4);
            scv1.deleteObserver(ab1);
            scv1.postaviPodatke(24, 7, 0.6);
            scv1.registerObserver(ab1);
            scv1.postaviPodatke(50, 12, 0.9);

        }
    }
}
