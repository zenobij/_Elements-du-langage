using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Models
{
    class Observer
    {
        public void Ecouter(object destinateur, MyArgs args)
        {
            Console.WriteLine(String.Format("Quelque chose est arrivé à {0} le {1:d/M/yyyy à HH:mm:ss}", destinateur, args.InstantT));
        }
    }
}
