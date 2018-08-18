using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Models
{
    class Observable
    {
        //Le delegue donne la possibilite de modifier la signature de l'événement
        //Dans ce cas, la classe MyArgs personnelle est utilisée a la place de l'EventArg classique
        //Dans le cas ou il n'y a pas nécéssité de personalisation, il n'est pas obligatoire de déclarer
        //un délégué. On créera alors un Event de type EventHandler qui n'a pas besoin de la déclaration
        //d'un délégué car il lui en est implicitement assigné un.
        public delegate void QuelqueChoseArrive(object destinateur, MyArgs message);
        //Déclaration de l'event basé sur le délégué ci-dessus
        public event QuelqueChoseArrive MonEvenement;

        public void Declenchement()
        {
            //Toujours vérifier si l'événement n'est pas null avant de la lancer 
            //Et donc, une méthode est-elle liée à la variable MonEvenement
            if (MonEvenement != null)
            {
                MonEvenement(this, new MyArgs());
            }
        }

        public override string ToString()
        {
            return "une instance d'observable";
        }
    }
}
