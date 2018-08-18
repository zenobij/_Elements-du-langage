using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization.Models
{
    public class Address
    {
        public string AddressType { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }

        [XmlIgnore] //Dit que cette propriété ne doit pas être reprise dans le fichier XML
        public string CodePorteEntree { get; set; }
    }
}
