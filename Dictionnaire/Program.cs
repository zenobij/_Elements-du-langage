using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un dictionnaire est une association clé -> valeur ou clé est unique
            Dictionary<string, string> dico = new Dictionary<string, string>();

            //Ajout d'éléments
            dico.Add("un", "chat");
            dico.Add("deux", "chien");
            dico.Add("trois", "oiseau");
            dico.Add("quatre", "poisson");

            //La méthode add génère une exeption si 2 clés sont identiques
            try
            {
                dico.Add("un", "souris");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Comme pour un tableau on peut utiliser des indexeurs
            //en précisant la clé en tant qu'index
            Console.WriteLine(dico["un"]);

            //Je peux utiliser les indexeurs pour écrire des valeurs
            dico["un"] = "chamois";

            //Si la clé n'existe pas il la crée
            dico["cinq"] = "renard";

            Console.WriteLine(dico["cinq"]); // -> donne renard

            //Si je demande une clé qui n'existe pas j'ai une exception
            try
            {
                Console.WriteLine(dico["trululu"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Si j'ai besoin de récupérer des valeurs mais j'ignore si la clé existe
            string laValeur = string.Empty;
            if (dico.TryGetValue("un", out laValeur))
            {
                Console.WriteLine("He oui la clé existe ! un = {0}", laValeur);
            }

            //La méthode ContainsKey qui permet de savoir si une clé existe ou pas
            if (!dico.ContainsKey("machin"))
            {
                Console.WriteLine("La clé machin n'existe pas");
            }

            //Pour répérer uniquement les clés
            var cles = dico.Keys;
            foreach (var item in cles)
            {
                Console.Write("{0}\t",item);
            }
            Console.WriteLine();

            //Pour récupérer uniquement les valeurs
            var valeurs = dico.Values;
            foreach (var item in valeurs)
            {
                Console.Write("{0}\t",item);
            }
            Console.WriteLine();

            //Pour énumérer les clés et les valeurs du dico
            foreach (var item in dico)
            {
                Console.WriteLine("cle {0} vaut {1}",item.Key,item.Value);
            }

            //Le nombre d'éléments dans le dico
            Console.WriteLine("Il y a {0} éléments dans le dico", dico.Count);

            //Suppression d'éléments dans le dico
            dico.Remove("un"); //efface la clé et aussi la valeur associée

            //Effacement radical
            dico.Clear();

            Console.ReadLine();
        }
    }
}
