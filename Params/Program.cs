using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Program
    {
        /*
         * Il arrive que l'on ne sache pas exactement combien de paramètres on devra envoyer à une méthode ou, plus simplement,
         * on désire prévoir plusieurs cas sans recourir à la surcharge.
         * Dans ce cas, on va utiliser le mot clé "PARAMS" suivit d'un tableau du type de valeurs à traiter.
         * Pour traiter n'importe quel type de valeurs ou d'objets, on peut bien sûr prévoir un tableau d'objets ! 
         */
        static void Main(string[] args)
        {
            Console.WriteLine(SumParameters(1));
            Console.WriteLine(SumParameters(1, 2));
            Console.WriteLine(SumParameters(3, 3, 3));
            Console.WriteLine(SumParameters(2, 2, 2, 2));

            Console.ReadLine();
        }

        //Un tableau temporaire va être créé et recevra tous les paramètres envoyés.
        //Il suffira de parcourir le tableau pour récupérer les paramètres.
        static int SumParameters(params int[] values)
        {
            int total = 0;
            foreach (int value in values)
            {
                total += value;
            }
            return total;
        }
    }
}
