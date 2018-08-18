using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This.Models
{
    public static class Extension
    {
        /*
         * Dans le cas des méthodes d'extension, this sera un modificateur de paramètres.
         * Ce modificateur va préciser que la méthode s'appliquera à l'instance d'une string.
         * Attention qu'une méthode d'extension est toujours statique et se trouve dans une classe statique également 
         */
        public static string Saluer(this string str)
        {
            return "Salutations";
        }
    }
}
