using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @object
{
    class Program
    {
        static void Main(string[] args)
        {
            //L'opération consistant à insérer un type valeur dans un type référence "object" s'appelle le boxing.
            //object est un alias pour "Object" le sommet de l'héritage. Il peut donc contenir n'importe quel objet ou
            //structure.
            int val = 12;
            object box = val;

            //La récupération de la valeur dans un type valeur s'appelle l'unboxing.
            //Certaines manières sont meilleures que d'autres suivant si l'on souhaite la levée d'exeptions ou non.

            int a = (int)box; //lève une exception

            int b;
            Int32.TryParse(box.ToString(), out b);//ne lève pas d'exception

            //La méthode la plus sûre mais la plus consommatrice de ressources
            Nullable<int> c = box as int?;
            if (c.HasValue)
            {
                int d = c.Value;
            }

	    //Pourtant on voit que l'objet contient bien un Int32
            Console.WriteLine(box.GetType());
            Console.WriteLine(a.GetType());

            Console.ReadLine();
        }
    }
}
