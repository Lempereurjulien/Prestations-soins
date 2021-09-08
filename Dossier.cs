using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;


namespace MaBoiteAOutils
{
    class Dossier
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private List<Prestations> listePrestations;

        //Constructeur
        public Dossier(string nom, string prenom, DateTime dateNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
        }

        //Constructeur ListePrestations
        public Dossier(string nom, string prenom, DateTime dateNaissance, List<Prestations> listePrestations)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.listePrestations = listePrestations;
        }

        //Property
        public string Nom { get => nom;}
        public string Prenom { get => prenom;}
        public DateTime DateNaissance { get => dateNaissance;}

        public int getNbJoursSoins(Dossier actuelle)
        {
            return listePrestations.Count;
        }

    }

    
}
