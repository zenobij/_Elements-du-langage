using Implicit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit
{
    class Program
    {
        static void Main(string[] args)
        {
            Vlad moi = new Vlad();
            string str = moi;
            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
