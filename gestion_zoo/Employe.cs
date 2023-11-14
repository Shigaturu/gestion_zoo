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
        public string Nom { get; set; }
        public int Age { get; set; }
        public Adresse Adresse { get; set; }

        public Employe(string nom, int age, Adresse adresse)
        {
            Nom = nom;
            Age = age;
            Adresse = adresse;
        }

        public void AfficherInfos()
        {
            Console.WriteLine($" Nom : {Nom}, Age : {Age} ");
            Adresse.AfficherAdresse();
        }

    }
}
