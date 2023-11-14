using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_zoo
{
    public class Lion : Animal
    {
        private char Sexe { get; set; }

        public Lion(string nom, string espece, int age, decimal taille, decimal poids, char sexe) : base(nom, espece, age, taille, poids)
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
            Console.WriteLine(this.Nom + " hurle .. ROAARRRRRRRRRRRRRRRRR");
            return;
        }

    }
}
