using Newtonsoft.Json;
using Serialization.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

/*
 * 
 * La sérialisation est un principe qui permet de transposer l'état d'un objet en sa représentation XML ou binaire ou Json
 * Pour effectuer une sérialisation XML j'ai besoin en C# d'un outil appelé serializer qui se trouve dans l'espace de nom System.Xml.Serialization;
 * 
 */

namespace Serialization
{
    class Program
    {
        //Le fichier output de la sérialisation
        //Environment permet d'accéder aux répertoires réservés du système quelque soit le Windows que l'on a
        //Cette variable est static parce que je vais l'utiliser dans Main qui est static => le static parle au static
        static string urlXml = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"FileExemple.xml");
        static string urlJson = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FileExemple.json");

        static void Main(string[] args)
        {
            //SerializeXml();
            //Person p = ReadXml();
            //Console.WriteLine(p);

            SerializeJson();
            Person pe = ReadJson();
            Console.WriteLine(pe);

            Console.ReadLine();
        }

        #region -- Serialization XML --

        static void SerializeXml()
        {
            //Créé par nécéssité 
            Person person = new Person {ID = 1, FirstName ="Gaston", Name="Lagaffe",GenderValue = Gender.Male};
            Address adresseDomicile = new Address {AddressType="Domicile", Street="Rue des machins", Number=14,City="Londres", CodePorteEntree="12345" };
            Address addressFacturation = new Address { Street= "Rue des bidules", Number= 25, City="Bruxelles", AddressType = "Facturation", CodePorteEntree="7895"};
            //Pour éviter un plantage en utilisant la liste contenue dans un objet il ne faut pas oublier d'instancier la liste (constructeur)
            person.ListAddress.Add(adresseDomicile);
            person.ListAddress.Add(addressFacturation);

            //J'initialise le méchanisme de sérialization à partir du type à sérialiser
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            
            //Pour écrire dans le fichier, il faut le créer à partir d'un flux
            //car le serailizer en a besoin
            //File.CreateText permet de créer le fichier s'il n'existe pas
            //Le flux est dans une clause using pour être sûr de libérer l'accès au fichier après notre action d'écriture
            using (StreamWriter writer = File.CreateText(urlXml))
            {
                serializer.Serialize(writer, person);
            }
        }

        static Person ReadXml()
        {
            //Sera le réceptacle de la lecture du fichier
            Person temp;
            //J'ai de nouveau besoin du serializer 
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            //J'ai besoin d'un flux de lecture du fichier Xml
            using(StreamReader reader = new StreamReader(urlXml))
            {
                temp = (Person)serializer.Deserialize(reader);
            }
            return temp;
        }
        #endregion

        #region -- Serialization JSON --
        //En C# il est recommandé d'utiliser NewtonSoft pour sérialiser du Json
        //C'est une librairie qui se charge en nuget

        static void SerializeJson()
        {
            //Créé par nécéssité 
            Person person = new Person { ID = 1, FirstName = "Gaston", Name = "Lagaffe", GenderValue = Gender.Male };
            Address adresseDomicile = new Address { AddressType = "Domicile", Street = "Rue des machins", Number = 14, City = "Londres", CodePorteEntree = "12345" };
            Address addressFacturation = new Address { Street = "Rue des bidules", Number = 25, City = "Bruxelles", AddressType = "Facturation", CodePorteEntree = "7895" };
            //Pour éviter un plantage en utilisant la liste contenue dans un objet il ne faut pas oublier d'instancier la liste (constructeur)
            person.ListAddress.Add(adresseDomicile);
            person.ListAddress.Add(addressFacturation);

            //La méthode SerializeObject crée une string qui est la sérialisation de l'objet en Json
            string output = JsonConvert.SerializeObject(person);

            //Pour écrire le contenu d'output dans un fichier j'utilise 
            //File et sa méthode WriteAllText 
            File.WriteAllText(urlJson, output);
        }

        static Person ReadJson()
        {
            string input = File.ReadAllText(urlJson);
            Person deserialized = JsonConvert.DeserializeObject<Person>(input);
            return deserialized;
        }

        #endregion
    }
}
