using Event.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciation des classes
            Observable observable = new Observable();
            Observer observer = new Observer();
            //Abonnement a l'événement
            observable.MonEvenement += observer.Ecouter;
            //Déclenchement de la méthode
            observable.Declenchement();

            Console.WriteLine();

            Radio r = new Radio("Marcel");
            Voisin v = new Voisin();

            r.AllumerRadio += v.FrapperAuMur;
            r.Allumage();

            Console.ReadKey();
        }
    }
}
