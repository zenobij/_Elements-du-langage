using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {

        static void Main(string[] args)
        {
            //Une variable dynamique se comporte comme une variable de type objet

            dynamic dyn = 1;
            object obj = 1;

            Console.WriteLine(dyn.GetType());
            Console.WriteLine(obj.GetType());

            //De fait, j'obtiens System.Int32 dans les 2 cas

            //Les choses changent si j'essaie d'effectuer des opérations
            //La vérifiaction ne se fait pas à la compilation mais à l'excécution

            dyn = dyn +1;
            //obj = obj + 1;

            //Une variable de type dynamique peut contenir n'importe quel type converti explicitement

            dynamic d;
            int i = 20;
            d = (dynamic)i;
            Console.WriteLine(d);

            string s = "Example";
            d = (dynamic)s;
            Console.WriteLine(d);

            DateTime dt = DateTime.Today;
            d = (dynamic)dt;
            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
