using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //Déclaration du délégué qui permet un nouveau type TypeDelegue 
    //une variable de ce type pourra contenir n'importe quelle méthode de la même signature  
    public delegate void TypeDelegue(string message);

    class Program
    {
        //La méthode qui sera pointée par le délégué puisque sa signature est valide
        public static void MethodeDuDelegue(string message)
        {
            Console.WriteLine(message);
        }

        //Autre méthode possédant une signature valide
        public static void AutreMethodeDuDelegue(string message)
        {
            Console.WriteLine(String.Format("Je dirais même plus {0}", message));
        }

        //Une utilité des délégués est de pouvoir être passés en paramètre de méthode
        public static void MethodeAvecDelegue(string x, string y, TypeDelegue retour)
        {
            retour(String.Format("Le message est: {0} {1} !", x, y));
        }

        static void Main(string[] args)
        {
            //Il n'y a pas de () à la fin du nom de la méthode car il s'agit d'une affectation
            TypeDelegue variable = MethodeDuDelegue;
            //Un délégué peut prendre à sa charge plusieurs méthodes ! On appelle cela le multicast
            //Toutefois le mécanisme n'est pas automatique, il faut le renseigner par l'opérateur +=
            //Ajout de la méthode AutreMethodeDuDelegue au délégué
            variable += AutreMethodeDuDelegue;

            //Les () enclenchent la ou les méthodes du délégué
            variable("Hello World !");

            Console.WriteLine(); Console.ReadKey();

            //De meme l'opérateur -= va soustraire la méthode du délégué
            variable -= AutreMethodeDuDelegue;

            variable("Hello Wallonie !");

            Console.WriteLine(); Console.ReadKey();

            MethodeAvecDelegue("Hello", "Hornu", variable);

            Console.WriteLine(); Console.ReadKey();

            //Il est tout à fait possible d'additionner des délégués s'ils sont de même définition
            //Cela donnera un délégué qui propose l'ensemble des méthodes
            TypeDelegue A = MethodeDuDelegue;
            TypeDelegue B = AutreMethodeDuDelegue;
            TypeDelegue C = A + B;
            C("Hello Technocite !");
            Console.WriteLine(); Console.ReadKey();
            //On peut aussi soustraire
            C -= B; // = C=C-B = C=A-B
            C("Hello Technocite !");

            Console.WriteLine(); Console.ReadKey();

            //Actions et fonctions

            affiche1();
            affiche2("Bonjour");
            affiche3("Bonjour", "Vlad");
            affiche4("Bonjour", "Vlad", 1);
            print("Bonjour");

            Console.WriteLine(); Console.ReadKey();

            Console.WriteLine(func1.Invoke(5));
            Console.WriteLine(func2.Invoke(true, 10));
            Console.WriteLine("Addition de 4 et 5 = " + add.Invoke(4, 5));

            Console.WriteLine(); Console.ReadKey();
        }

        //Lorsqu'un délégué ne retourne rien, on peut utiliser sa version générique Action
        //vient de : public delegate void Action<in T>(T obj)
        static Action affiche1 = () => Console.WriteLine("coucou");
        //Avec paramètre
        static Action<string> affiche2 = (s) => Console.WriteLine(s);
        //Avec 2 paramètres
        static Action<string, string> affiche3 = (s, t) => Console.WriteLine("{0} {1} !!!", s, t);
        //Avec 3 paramètres différents
        static Action<string, string, int> affiche4 = (s, t, u) => Console.WriteLine("{0} {1} {2} !!!", s, t, u);

        //Ceci permet de faire un pré-traitement avant l'affichage 
        static Action<string> print = (s) => Console.WriteLine("{0:H:mm:ss} - {1}", DateTime.Now, s);


        //Lorsqu'un délégué retourne quelque chose, on peut utiliser sa forme Func
        //Le second paramètre générique est le type de retour
        //vient de : public delegate TResult Func<in T, out TResult>(T arg)
        static Func<int, string> func1 = (x) => string.Format("string = {0}", x);
        static Func<bool, int, string> func2 = (b, x) => string.Format("string = {0} et {1}", b, x);
        static Func<int, int, double> add = (a, b) => a + b;
        //retourne le modulo du paramètre 1(double) par le paramètre 2(double)
        static Func<double, double, string> modu = (a, b) => string.Format("Modulo = {0}", a % b);
        //converti un double en int
        static Func<double, int> converter = (a) => Convert.ToInt32(a); 
    }
}
