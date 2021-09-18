using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBoiteAOutils;
using soins;


namespace ClassesMetier
{
    public class Intervenant
    {
        protected string nom;
        protected string prenom;
        List<Prestations> listePrestations= new List<Prestations>();

        //Constructeur
        public  Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        //Property
        public string Nom { get => nom;}
        public string Prenom { get => prenom;}

        //Méthode
        public override string ToString()
        {
            return "Intervenant :" + this.nom + " - " + this.prenom;
        }

        public int GetNbPrestationsI(Intervenant intervenant)
        {
            int getNbpresta= 0;
            foreach (Prestations prestations in listePrestations) 
            { 
                if(prestations.Intervenant.nom == intervenant.nom)
                {
                    getNbpresta++;
                }
            }
            return getNbpresta;
        }

        public int GetNbPrestation()
        {
            return listePrestations.Count();
        }
        public void ajoutePrestations(Prestations nouvellePresta)
        {
            listePrestations.Add(nouvellePresta);

        }
    }   
}
