using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_zoo
{
    public class Animal
    {
        public string Nom { get; set; }
        public string Espece { get; set; }
        public int Age { get; set; }
        public decimal Taille { get; set; }
        public decimal Poids { get; set; }

        public Animal(string nom, string espece, int age, decimal taille, decimal poids)
        {
            Nom = nom;
            Espece = espece;
            Age = age;
            Taille = taille;
            Poids = poids;
        }

        public void AfficherDetails()
        {
            Console.WriteLine("Nom : " + Nom + "\nEspece : " + Espece + "\nAge : " + Age + " ans" +  "\nTaille : " + Taille + " cm" + "\nPoids : " + Poids + " kg" + "\n" );
        }

        public void Manger()
        {
            Console.WriteLine(this.Nom + " se pète le bide au Tacos du coin");
        }

        public void DemandeAjoutUser()
        {
            Console.WriteLine("");
        }

        public static Animal CreerAnimalDepuisConsole()
        {

            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Espece : ");
            string espece = Console.ReadLine();

            Console.Write("Age : ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Saisie incorrecte pour l'âge.");
                return null;
            }

            Console.Write("Taille en cm : ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal taille))
            {
                Console.WriteLine("Saisie incorrecte pour la taille.");
                return null;
            }

            Console.Write("Poids en kg : ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal poids))
            {
                Console.WriteLine("Saisie incorrecte pour le poids.");
                return null;
            }


            return new Animal(nom, espece, age, taille, poids);
        }
    }
}

