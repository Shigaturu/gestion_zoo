﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_zoo
{
    public class Zoo
    {
        #region Propriétés
        public string Nom { get; set; }
        public Adresse Adresse { get; set; }
        public Animal Animal { get; set; }
        public Employe Employe { get; set; }

        public List<Employe> ListEmploye = new List<Employe>();

        public List<Animal> ListAnimal = new List<Animal>();
        #endregion

        #region Constructeur
        public Zoo(string nom, Adresse adresse)
        {
            Nom = nom;
            Adresse = adresse;
        }
        #endregion

        #region Méthodes
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
                employe.AfficherInfos();
            }
        }

        public void AfficherAnimal()
        {
            Console.WriteLine("\nAFFICHAGE DES ANIMAUX");

            foreach (Animal animal in ListAnimal)
            {
                animal.AfficherDetails();
            }

        }
        public void CreerEmployeDepuisConsole()
        {
            Console.WriteLine("Création d'un nouvel employé");

            Employe nouvelEmploye = Employe.CreerEmployeDepuisConsole();

            if (nouvelEmploye != null)
            {
                ListEmploye.Add(nouvelEmploye);
                Console.WriteLine("Employé ajouté avec succès !");
            }
            else
            {
                Console.WriteLine("Erreur lors de la création de l'employé.");
            }
        }


        public void CreerAnimalDepuisConsole()
        {
            Console.WriteLine("Création d'un nouvel animal");

            Animal nouvelAnimal = Animal.CreerAnimalDepuisConsole();

            if (nouvelAnimal != null)
            {
                ListAnimal.Add(nouvelAnimal);
                Console.WriteLine("Animal ajouté avec succès !");
            }
            else
            {
                Console.WriteLine("Erreur lors de la création de l'animal.");
            }
        }
        #endregion

    }
}