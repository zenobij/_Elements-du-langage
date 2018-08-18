using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Models
{
    class Legume : Plante
    {
        public override string ToString()
        {
            //Ici base renvoie à la méthode ToString de l'objet parent
            //Dans ce cas, l'objet parent est Object et sa méthode ToString renvoie
            //le namespace et le nom de l'objet
            return base.ToString() + " et je suis bon pour la santé";
        }

        public string Murir()
        {
            //Je peux appeller la méthode Pousser de mon parent sans faire appel à base puisque je reçois la méthode par héritage
            return "Je donne de beaux fruits mais avant " + Pousser();
        } 

        public  override string Fleurir()
        {
            //Dans ce cas je dois utiliser base pour signifier que je veux la méthode Fleurir de mon parent et pas la mienne
            //Si j'utilisais la mienne, dans ce cas, j'irais droit au stackoverflow (appel récursif)
            return "je donne des légumes mais avant " + base.Fleurir();
        }
    }
}
