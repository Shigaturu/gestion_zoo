using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_zoo
{
    public class Soigneur : Employe
    {
        public Soigneur(string nom, int age, Adresse adresse) : base(nom, age, adresse)
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

        public void Nourrir(Animal nom)
        {
            Console.WriteLine(this.Nom + " nourrit " + nom);
        }
    }
}
