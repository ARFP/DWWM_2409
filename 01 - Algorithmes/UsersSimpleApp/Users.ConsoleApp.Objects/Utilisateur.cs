﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Users.ConsoleApp.Objects
{
    public class Utilisateur
    {
        //private Guid id;
        
        private string nom;

        private string prenom;

        private DateTime dateDeNaissance;

        private string? metier;

        private string? couleurPreferee;


        public Utilisateur(string _nomPrenom, string _dateDeNaissance)
        {
            string[] nomPrenomSepare = _nomPrenom.Split(" ");
            this.nom = nomPrenomSepare[0];
            this.prenom = nomPrenomSepare[1];

            if(!DateTime.TryParse(_dateDeNaissance, out dateDeNaissance))
            {
                throw new ArgumentException("Date de naissance invalide !");
            }

            if(dateDeNaissance > DateTime.Now)
            {
                throw new ArgumentException("La date doit être dans le passé !");
            }

            //

        }

        public string GetNomComplet()
        {
            return nom + " " + prenom;
        }


        public string GetDateDeNaissance()
        {
            return dateDeNaissance.ToShortDateString();
        }

        public int GetAge()
        {
            TimeSpan intervalle = DateTime.Now - dateDeNaissance;
            int age = (int)(intervalle.Days / 365.25);
            return age;
        }

        public bool IsMajeur()
        {
            int age = this.GetAge();

            return age > 18;
        }

        public string GetCouleurOuMetier()
        {
            return "";
        }
    }
}