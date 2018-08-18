using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Models
{
    class Voisin
    {
        public void FrapperAuMur(object sender, MyArgs args)
        {
            Radio r = sender as Radio;
            Console.WriteLine("{0} ! Arrête de faire du bruit à {1:HH} heure", r.Proprio, args.InstantT);
        }
    }
}
