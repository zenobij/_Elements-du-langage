using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization.Models
{
    //Grâce aux dataannotations XmlEnum je peux renommer un enum
    //pour son affichage en XML
    public enum Gender
    {
        [XmlEnum("Homme")]
        Male,
        [XmlEnum("Femme")]
        Female
    }
}
