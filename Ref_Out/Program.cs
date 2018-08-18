using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sans utiliser d'objets, il n'est pas possible de retourner plus d'une valeur à partir d'une méthode.
             * Si l'on a besoin tout de même de retourner 2 valeurs pour, par exemple revoyer un booléen en plus du résultat d'un calcul ou d'une conversion,
             * il faudra qu'un des paramètres de la méthode soit précédé du mot clé "OUT".
             * Le résultat du traitement sera affecté à la variable directement sans passer par le mécanisme de sortie traditionnel. 
             */
            if (TryDivideByTwo(10, out result))
            {
                Console.WriteLine("La division de {0} par 2 donne {1}", result * 2, result);
            }
            else
                Console.WriteLine("Impossible de diviser ce nombre impair, result vaut {0}",result);


            /*
             * Le mot clé "REF" renvoie bien sûr à la notion de référence. Ici, le paramètre est passé à la méthode non en tant que valeur mais en tant que référence.
             * La différence est que la variable sera modifiée immédiatement depuis la méthode sans même avoir besoin de prévoir un mode de sortie.
             * Pas de magie pour autant. Si dans une méthode les variables sont locales, grâce au mot "ref" on va donner à la méthode l'adresse mémoire de la variable. 
             * La variable doit être déclarée ET INITIALISEE avant l'appel de la méthode !
             */

            string str = "phrase a inverser";

            ReverseString(ref str);

            Console.WriteLine(str);


            Console.ReadLine();
        }

        //La variable utilisée comme paramètre de sortie doit toujours être déclarée avant la méthode
        //Il n'est pas indispensable que la variable soit initialisée. Elle le sera dans la méthode
        static int result;
        //Il est normal que le nom de la variable reste le même en tant que paramètre de la méthode
        public static bool TryDivideByTwo(int value, out int result)
        {
            if (value % 2 != 0)
            {
                //la variable de sortie doit toujours être initialisée avant de quitter la méthode
                result = 0;
                return false;
            }
            result = value / 2;
            return true;
        }


        //La méthode n'a pas de paramètre de sortie, pourtant la string sera modifiée
        public static void ReverseString(ref string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            value = new string(charArray);
        }
    }
}
