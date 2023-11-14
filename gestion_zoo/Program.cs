// See https://aka.ms/new-console-template for more information
using gestion_zoo;

Adresse uneAdresse = new Adresse("23 rue", "Tls", "31400");
Zoo leZoo = new Zoo("Zoo tah les fous", uneAdresse);

Animal hector = new Animal("Hector", "Chien", 8, 60, 20);
Animal rox = new Animal("Rox", "Chat", 4, 30, 5);
leZoo.ListAnimal.Add(hector);
leZoo.ListAnimal.Add(rox);

bool continueCalcul = true;

do
{
    Console.WriteLine("\n[1] Afficher la liste d'employés\n[2] Afficher la liste d'animaux\n[3] Afficher les informations du zoo\n[4] Ajouter un nouvel employé\n[5] Ajouter un nouvel animal\n[N] Autre pour quitter");
    string reponseContinue = Console.ReadLine();

    // Votre logique précédente avec le switch
    switch (reponseContinue)
    {
        case "1":
            leZoo.AfficherEmploye();
            break;

        case "2":
            leZoo.AfficherAnimal();
            break;

        case "3":
            leZoo.AfficherInfo();
            break;
        case "4":
            leZoo.CreerEmployeDepuisConsole();
            break;
        case "5":
            leZoo.CreerAnimalDepuisConsole();
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












//Zoo unZoo = new Zoo("Zoo tah les fous", uneAdresse);



//Loup unLoup = new Loup("Kevin", "md", 12, 54, 51, 'M');

//Employe unEmploye = new Employe("Bilal", 20, uneAdresse);
//Employe unEmploye1 = new Employe("KEKEKEKEKE", 50, uneAdresse);

//unZoo.ListEmploye.Add(unEmploye);
//unZoo.ListEmploye.Add(unEmploye1);
//unZoo.AfficherAnimal();

