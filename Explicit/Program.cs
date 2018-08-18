using Explicit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit
{
    class Program
    {
        // Démonstration du mot clé "explicit" permetant un cast, une conversion entre 2 objets.
        // Pour l'exemple nous allons convertir un objet Fahrenheit en Celcius.
        static void Main(string[] args)
        {
            Fahrenheit fahr = new Fahrenheit(32);
            Console.Write("{0} Fahrenheit", fahr.Degrees);

            Celsius c = (Celsius)fahr;
            Console.Write(" = {0} Celsius", c.Degrees);

            Console.ReadLine();
        }
    }
}
