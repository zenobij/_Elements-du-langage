using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This.Models
{
    /*
     * This signifie l'instance actuelle de la classe Ambigue.
     * Dans ce cas, this va servir à lever l'ambiguité de nommage des variables.
     * A noter que this ne fonctionne pas en static, seulement en instance.
     */
    class Ambigue
    {
        string a = string.Empty;

        public Ambigue(string a)
        {
            this.a = a;
        }
        /*
         * Attention à ne pas exagérer...
         * Si nous ajoutons encore une nouvelle variable "a", tout est perdu !
         * Il n'y a pas de "This local".
         */
        public void Methode(/*string a*/)
        {
            string a = string.Empty;

            this.a = a;

        }
    }
}
