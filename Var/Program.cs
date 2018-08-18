using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Var.Models;

namespace Var
{
    class Program
    {
        /*
         * "var" est souvent vu uniquement comme un 'syntaxic sugar' c'est à dire une facilité d'écriture pour le développeur.
         * Pourtant à y regarder de plus près, var est tout à fait indispensable dans bien des situations. 
         */
        static void Main(string[] args)
        {
            Personne p1 = new Personne { Id = 1, Nom = "nom1", Prenom = "prenom1" };
            Personne p2 = new Personne { Id = 2, Nom = "nom2", Prenom = "prenom2" };
            Personne p3 = new Personne { Id = 3, Nom = "nom3", Prenom = "prenom3" };

            List<Personne> liste = new List<Personne> { p1, p2, p3 };

            /* Lorsque j'effectue une sélection sur les objets de ma liste, ne prenant que leur nom et prénom sans leur ID,
             * je crée un nouvel objet qui n'a pas de nom => un objet anonyme.
             * Pour pouvoir utiliser un objet d'un tel type, je vais utiliser le mot clé "var".
             * Derrière le mot, se cache ce que l'on appelle "l'inférence de types locaux" qui dit qu'à la compilation, le mot
             * var va être remplacé par le type de la variable avec laquelle on désire l'initialiser.
             */
            var toto = liste.Select(x => new { x.Nom, x.Prenom }).ToList();

            /*
             * En demandant quel est le type de la variable toto, on obtient :
             *  <>f__AnonymousType0`2[System.String,System.String] preuve qu'en c# tout objet possède un type
             * Cependant, il n'est pas possible pour le développeur de connaître ce type => l'utilité de var.
             * Vous l'aurez deviné, var est un ajout au langage qui coincide avec l'arrivée de Linq et ses multiples possibilités de sélection.
             */

            Console.WriteLine(toto.GetType());
            Console.WriteLine(toto[0].GetType());

            /*
             * Bien sûr, par extension, cela signifie que je peux créer moi même un type anonyme au besoin
             * Ceci est parfois utilie pour créer un objet à la volée
             */
            var temp = new { Nom = "Paul", Prenom = "Tourtel" };

            Console.WriteLine(temp.GetType().Name);

            Console.ReadLine();
        }
    }
}
