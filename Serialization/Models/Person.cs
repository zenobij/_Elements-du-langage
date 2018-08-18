using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization.Models
{
    [XmlType("Personne")] //Pour renommer une classe on n'utilise pas XmlElement !
    public class Person
    {
        [XmlElement("Identifiant")] //ID s'appelle en XML Identifiant
        public int ID { get; set; }

        [XmlElement("Nom")]
        public string Name { get; set; }

        [XmlElement("Prenom")]
        public string FirstName { get; set; }

        [XmlArray("Adresses")]    //Nom de la liste d'adresses
        [XmlArrayItem("Adresse")] //Nom de chacune des adresses une à une
        public List<Address> ListAddress { get; set; }

        [XmlElement("Genre")]
        public Gender GenderValue { get; set; }

        //Constructeur pour initialiser la liste d'addresses
        public Person()
        {
            ListAddress = new List<Address>();
        }

        //En XML on sérialize jamais les méthodes
        public override string ToString()
        {
            return $"{GenderValue} {ID} {FirstName} {Name} {ListAddress.Count} adresse(s)";
        }

    }
}
