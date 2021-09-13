using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using MaBoiteAOutils;


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

        //Méthodes
            //Ajoutes une prestations au dossier
        public void ajoutePrestations(Prestations nouvellePresta) 
        {
            listePrestations.Add(nouvellePresta);
            
        }

            //Compte le nombre de jour de soins avec la méthode "count"
        public int getNbJoursSoins(Dossier actuelle)
        {
            int getNbJours = actuelle.listePrestations.Count;
            Prestations presta;

            for(int i =0;i<actuelle.listePrestations.Count-1;i++)
            {
                for (int a = i+1; a < actuelle.listePrestations.Count; a++)
                {
                    presta = actuelle.listePrestations[i];
                    if (presta.compareTo(presta, actuelle.listePrestations[a]) == 0)
                    {
                        getNbJours -= 1;
                    }
                    
                }
            }         
                return getNbJours;
        }

            //Compte le nombre de jour de soins avec la méthode foreach
        public int getNbjoursSoinsV2(Dossier actuelleV2)
        {
            int getNbJoursSoins = 0;
            foreach(Prestations prestations in listePrestations)
            {
                
                getNbJoursSoins += 1;
            }
            return getNbJoursSoins;
         }

        public int getNbPrestationsExternes(Dossier choisi)
        {
            int NbPrestationsExternes = 0;
            foreach (Prestations prestaExterne in choisi.listePrestations)
            {
                if (prestaExterne.IntervenantExterne is null) 
                {
                    
                }
                else
                {
                    NbPrestationsExternes++;
                }
            }

            //foreach (Prestations prestationsExterne in choisi.listePrestations)
            //{
            //    if (listePrestations(prestationsExterne.IntervenantExterne))
            //    {
            //        NbPrestationsExternes += 1;
            //    }
            //}

            return NbPrestationsExternes;
        }

        public int getNbPrestations(Dossier choisi)
        {
            return choisi.listePrestations.Count();
        }
    }

    
}
