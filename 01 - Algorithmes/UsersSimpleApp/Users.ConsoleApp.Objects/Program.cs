﻿namespace Users.ConsoleApp.Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enregistrement d'utilisateurs (gestion avec Objet Métier).");

            //Variable
            DateTime formaDate;
            DateTime ajd = DateTime.Now;
            int age = 0;
            string saisieNomPrenom;
            string saisieDate;
            string? metierCouleur = null;
            ConsoleKey continuerO_N;
            List<Utilisateur> utilisateurs = new();

            //Traitement
            do
            {


                /* 

                 if (age < 0)
                 {
                     Console.WriteLine("Saisie non valide.");
                 }

                 else if (age < 18)
                 {
                     Console.WriteLine("couleur préféré ?");
                     metierCouleur = Console.ReadLine();
                 }
                 else
                 {
                     Console.WriteLine("Votre metier ?");
                     metierCouleur = Console.ReadLine();
                 }*/

                // string[] unUtilisateur = [saisieNomPrenom, saisieDate, age.ToString(), metierCouleur];

                Console.WriteLine("Saisissez le nom et Prénom.");
                saisieNomPrenom = Console.ReadLine();

                Console.WriteLine("Saisissez la date de naissane, jour/mois/année.");
                saisieDate = Console.ReadLine();

                try
                {
                    Utilisateur unUtilisateur = new Utilisateur(saisieNomPrenom, saisieDate);
                    utilisateurs.Add(unUtilisateur);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                

                

                Console.WriteLine("Voulez vous saisir un autre utilisateur : N/O ?");
                continuerO_N = Console.ReadKey(true).Key;



            }
            while (continuerO_N == ConsoleKey.O);


            // Affichage de la liste des utilisateurs

            // List<Utilisateur]> utilisateurs = new();
            foreach (Utilisateur utilisateur in utilisateurs)
            {
                Console.Write("Nom et Prénom : " + utilisateur.GetNomComplet() + " - ");
                Console.Write("Date de naissance (âge): " + utilisateur.GetDateDeNaissance() + " (" + utilisateur.GetAge() + ")");
            }

        }
    }
}
