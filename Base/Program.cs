using Base.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    //Imaginons une classe A qui sera la classe de base puisque la notion de "base" sous-entend la notion d'héritage.
    public class A 
    {
        public A(int value)
        {
            // L'instanciation de la classe provoque un affichage
            Console.WriteLine("Constructeur de A()");
        }
    }

    //Imaginons une classe B qui hérite de A
    public class B : A 
    {
        public B(int value): base(value)
        {
            //Le constructeur de A sera appelé avant le constructeur de B
            Console.WriteLine("Constructeur de B()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A(0);
            B b = new B(1);

            Legume carotte = new Legume();
            Console.WriteLine(carotte);

            Console.WriteLine(carotte.Murir());
            Console.WriteLine(carotte.Fleurir());

            Console.ReadLine();
        }
    }
}
