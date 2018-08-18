using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit.Models
{
    class Vlad
    {
        // Contrairement à la conversion explicite qui demandais l'opérateur de cast, la conversion implicite ne demande aucun opérateur.
        public static implicit operator string(Vlad d)
        {
            return "Je suis le maître du monde";
        }
    }
}
