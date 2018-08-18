using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit.Models
{
    class Fahrenheit
    {
        public float Degrees { get; }
        public Fahrenheit(float temp)
        {
            Degrees = temp;
        }
        // C'est dans cette méthode que l'on va préciser ce qui se passe lors du cast obligatoire du fait du mot "explicit".
        // La méthode ne se trouve pas dans Celcius mais bien dans Fahrenheit, c'est au type source de fournir l'opérateur de conversion.
        // Après le traitement approprié la méthode rtourne un objet Celsius.

        public static explicit operator Celsius(Fahrenheit fahr)
        {
            return new Celsius((5.0f / 9.0f) * (fahr.Degrees - 32));
        }
    }
}
