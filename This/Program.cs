using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using This.Models;

namespace This
{
    class Program
    {
        //Voir les classes dans Models
        static void Main(string[] args)
        {
            Ambigue classe = new Ambigue("message");

            Constructeur c = new Constructeur("Marcel", "Bernard", 15);
            Console.WriteLine(Constructeur.Compteur);

            string s = string.Empty;
            Console.WriteLine(s.Saluer());

            Console.ReadLine();
        }

        //Il y a encore un cas d'utilisation de this en valeur de retour cette fois.
        //Ce cas se trouve dans la section event
    }
}
