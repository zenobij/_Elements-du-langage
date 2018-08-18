using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Models
{
    class Radio
    {
        public string Proprio { get; set; }

        public Radio(string p)
        {
            Proprio = p;
        }

        public delegate void QuelqueChoseArrive(object destinateur, MyArgs message);
 
        public event QuelqueChoseArrive AllumerRadio;

        public void Allumage()
        {
            if (AllumerRadio != null)
            {
                AllumerRadio(this, new MyArgs());
            }
        }

        public override string ToString()
        {
            return string.Format("La radio de {0}",Proprio);
        }
    }
}
