using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using MaBoiteAOutils;
using Soins2021;


namespace MaBoiteAOutils
{
   public class Dossier
    {
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private List<Prestations> listePrestations;
        private DateTime dateCreation;

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
            if(dateNaissance > DateTime.Now)
            {
                throw new SoinsException("La date de naissance du dossier ne peut pas être supérieur à la date actuelle.")
            }
            this.listePrestations = listePrestations;
            this.dateCreation = DateTime.Now;
        }
        public Dossier(string nom, string prenom, DateTime dateNaissance, List<Prestations> listePrestations, DateTime dateCreation)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.listePrestations = listePrestations;
            this.dateCreation = dateCreation;
        }



        //Property
        public string Nom { get => nom;}
        public string Prenom { get => prenom;}
        public DateTime DateNaissance { get => dateNaissance;}
        public DateTime DateCreation { get => dateCreation;}


        //Méthodes
        //Ajoutes une prestations au dossier
        public void ajoutePrestations(Prestations nouvellePresta) 
        {
            if (nouvellePresta.DateHeureSoin > DateTime.Now){
                throw new SoinsException("La date de prestation ne peut pas être supérieur à la date actuelle");
            } 
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
            int getNbJoursSoins = actuelleV2.listePrestations.Count;           
            for (int i = 0; i < actuelleV2.listePrestations.Count - 1; i++)
            {
                for (int a = i + 1; a < actuelleV2.listePrestations.Count; a++)
                {
                    var presta = actuelleV2.listePrestations[i].DateHeureSoin.Date;
                    if (presta==actuelleV2.listePrestations[a].DateHeureSoin.Date)
                    {
                        getNbJoursSoins -= 1;
                    }
                }
            }
            return getNbJoursSoins;
         }

        public int getNbPrestationsExternes(Dossier choisi)
        {
            int NbPrestationsExternes = 0;
            foreach (Prestations prestaExterne in choisi.listePrestations)
            {
                if (prestaExterne.Intervenant is IntervenantExterne) 
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

        public override string ToString()
        {
            string s = "-----Début de dossier----------";
            s += "\nNom :" + this.nom + "Prenom :" + this.prenom + "Date de naissance : " + this.dateNaissance;
            foreach(Prestations unePrestation in this.listePrestations)
            {
                s += "\n" + unePrestation.ToString();
                
            }
            string a = "\n----Fin dossier-----";
            s+=a;
            return s;
        }
    } 
}