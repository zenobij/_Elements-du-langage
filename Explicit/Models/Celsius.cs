using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit.Models
{
    class Celsius
    {
        public float Degrees { get; }
        public Celsius(float temp)
        {
            Degrees = temp;
        }
    }
}
