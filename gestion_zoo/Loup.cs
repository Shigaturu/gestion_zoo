using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestion_zoo;

namespace gestion_zoo
{
    public class Loup : Animal
    {
        private char Sexe { get; set; }

        public Loup(string nom, string espece, int age, decimal taille, decimal poids, char sexe) : base (nom, espece, age, taille, poids)
        {
            Nom = nom; 
            Espece = espece;
            Age = age;
            Taille = taille;
            Poids = poids;
            Sexe = sexe;
        }

        public void Hurler()
        {
            Console.WriteLine(this.Nom + " hurle .. AHOUUUUUUUUUUUUUUUUUUUUUUUUUU");
            return;
        }

    }
}
