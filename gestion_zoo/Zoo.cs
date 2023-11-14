using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_zoo
{
    public class Zoo
    {
        public string Nom { get; set; }
        public Adresse Adresse { get; set; }
        public Animal Animal { get; set; }
        public Employe Employe { get; set; }

        public List<Employe> ListEmploye = new List<Employe>();
        public List<Animal> ListAnimal = new List<Animal>();

        public Zoo(string nom, Adresse adresse) 
        {
            Nom = nom;
            Adresse = adresse;
        }
        public void AfficherInfo()
        {
            Console.WriteLine("\nAFFICHAGE DES INFORMATIONS DU ZOO");
            Console.WriteLine($"Nom du zoo : {Nom}");
        }

        public void AfficherEmploye() 
        {
            Console.WriteLine("\nAFFICHAGE DES EMPLOYES");

            foreach (Employe employe in ListEmploye)
            {
                Console.WriteLine($"Nom: {employe.Nom} | Age: {employe.Age}");
            }
        }

        public void AfficherAnimal()
        {
            Console.WriteLine("\nAFFICHAGE DES ANIMAUX");

            foreach (Animal animal in ListAnimal)
            {
                Console.WriteLine($"Nom: {animal.Nom}, Age: {animal.Age}");
            }
        }
    }
}
