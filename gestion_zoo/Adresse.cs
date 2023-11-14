using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gestion_zoo
{
    public class Adresse
    {
        public string Rue { get; set; }
        public string Ville { get; set; }
        public string CodePostal { get; set; }

        public Adresse(string rue, string ville, string codepostal)
        {
            Rue = rue;
            Ville = ville;
            CodePostal = codepostal;
        }

        public void AfficherAdresse()
        {
            Console.WriteLine($"Adresse : {Rue} ' ' {Ville} ' ' {CodePostal}  ");
        }


        public static Adresse CreerAdresseDepuisConsole()
        {
            Console.WriteLine("Création d'une nouvelle adresse");

            Console.Write("Rue : ");
            string rue = Console.ReadLine();



            Console.Write("Ville : ");
            string ville = Console.ReadLine();

            string codePostal;
            do
            {
                Console.Write("Code postal (format valide : XXXXX) : ");
                codePostal = Console.ReadLine();
            } while (!EstCodePostalValide(codePostal));


            return new Adresse (rue, ville, codePostal);
        }
        private static bool EstCodePostalValide(string codePostal)
        {
            // Expression régulière pour un code postal français à cinq chiffres
            string pattern = @"^\d{5}$";
            return Regex.IsMatch(codePostal, pattern);
        }
    }
}
