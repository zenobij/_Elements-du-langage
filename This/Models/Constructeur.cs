using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This.Models
{
    /*
     * This est aussi utilie dans le passage de paramètres entre constructeurs
     * Un peu dans le même esprit que base mais dans une seule classe
     * Dans cet exemple, j'expose 2 constructeurs publics avec 2 et 3 paramètres
     * Chacun fait sa part d'initialisation ainsi que le déclenchement du constructeur sans paramètres
     */
    class Constructeur
    {
        public static int Compteur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// constructeur privé appelé depuis le constructeur à 2 paramètres
        /// </summary>
        private Constructeur()
        {
            Compteur++;
        }

        public Constructeur(string n, string p):this()
        {
            Nom = n;
            Prenom = p;
        }

        public Constructeur(string n, string p, int a):this(n,p)
        {
            Age = a;
        }
    }
}
