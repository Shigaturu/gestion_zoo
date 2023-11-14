using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
