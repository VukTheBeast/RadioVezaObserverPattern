using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioVezaObserver.Interfaces
{
    interface IObserver
    {
        void update(int brojProtivnickihVojnika, int brojOMV, double indexJacine);
    }
}
