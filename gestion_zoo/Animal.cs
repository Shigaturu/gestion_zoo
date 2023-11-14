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
            Console.WriteLine("Nom : " + Nom + "\nEspece : " + Espece);
        }

        public void Manger()
        {

        }
    }
}
