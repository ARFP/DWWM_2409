using System;
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


        public Utilisateur()
        {

        }


        public int GetAge()
        {
            return 0;
        }

        public bool IsMajeur()
        {
            return false;
        }

        public string GetCouleurOuMetier()
        {
            return "";
        }

        public string GetDateDeNaissance()
        {
            return "";
        }

        public string GetNomComplet()
        {
            return prenom + " " + nom;
        }
    }
}