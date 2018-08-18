using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Models
{
    class MyArgs : EventArgs
    {
        public DateTime InstantT { get; set; }

        public MyArgs()
        {
            InstantT = DateTime.Now;
        }
    }
}
