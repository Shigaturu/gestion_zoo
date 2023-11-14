using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_zoo
{
    // Composition
    public class Employe
    {
        #region Propriétés
        public string Nom { get; set; }
        public int Age { get; set; }
        public Adresse Adresse { get; set; }
        #endregion

        #region Constructeur
        public Employe(string nom, int age, Adresse adresse)
        {
            Nom = nom;
            Age = age;
            Adresse = adresse;
        }
        #endregion

        #region Méthodes
        public void AfficherInfos()
        {
            Console.WriteLine($"Nom : {Nom}, Age : {Age} ans ");
            Adresse.AfficherAdresse();
        }


        public static Employe CreerEmployeDepuisConsole()
        {

            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Age : ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Saisie incorrecte pour l'âge.");
                return null;
            }

            Console.WriteLine("Adresse :");
            Adresse adresse = Adresse.CreerAdresseDepuisConsole();

            return new Employe(nom, age, adresse);
        }
        #endregion
    }

}