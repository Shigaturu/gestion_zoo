using gestion_zoo;

#region Program
// Instanciation en dur pour test affichage
Adresse uneAdresse = new Adresse("23 rue", "Tls", "31400");
Zoo leZoo = new Zoo("Zoo tah les fous", uneAdresse);

Loup hector = new Loup("Hector", "Chien", 8, 60, 20, 'M');
Lion rox = new Lion("Rox", "Lion", 4, 30, 5,'M');
leZoo.ListAnimal.Add(hector);
leZoo.ListAnimal.Add(rox);


// Début application console
bool continueCalcul = true;

do
{
    Console.WriteLine("\n[1] Afficher la liste d'employés\n" +
        "[2] Ajouter un nouvel employé\n" +
        "[3] Afficher la liste d'animaux\n" +
        "[4] Ajouter un nouvel animal\n" +
        "[5] Afficher les informations du zoo\n" +
        "[?] Autre pour quitter");
    string reponseContinue = Console.ReadLine();

    switch (reponseContinue)
    {
        case "1":
            leZoo.AfficherEmploye();
            break;
        case "2":
            leZoo.CreerEmployeDepuisConsole();
            break;
        case "3":
            leZoo.AfficherAnimal();
            break;
        case "4":
            leZoo.CreerAnimalDepuisConsole();
            break;
        case "5":
            leZoo.AfficherInfo();
            break;
        case "N":
        case "n":
            continueCalcul = false;
            break;
        default:
            continueCalcul = false;
            break;
    }
    if (continueCalcul == true)
    {
        // Logique pour demander si l'utilisateur veut continuer
        Console.WriteLine("Voulez-vous faire une autre demande ? O/N");
        reponseContinue = Console.ReadLine();
        continueCalcul = (reponseContinue.ToLower() == "o");
    }

} while (continueCalcul);
#endregion