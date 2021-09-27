using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using soins;
using Soins2021;


namespace MaBoiteAOutils
{
   public class Prestations
    {
        private string libelle;
        private DateTime dateHeureSoin;
        private Intervenant intervenant;
       

        //Constructeur
        public Prestations(string libelle, DateTime dateHeureSoin,Intervenant intervenant)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
            if(dateHeureSoin > DateTime.Now)
            {
                throw new SoinsException("La date de prestation doit être inférieure à la date courante");
            }
            this.intervenant = intervenant;
        }

        

        

        //Property
        public string Libelle { get => libelle;}
        public DateTime DateHeureSoin { get => dateHeureSoin;}
        public Intervenant Intervenant { get => intervenant; }
        

        //Méthodes
        //Renvoi la date la plus vielle entre les 2 prestations
        public int compareTo(Prestations une, Prestations deux)
        {
            var date = une.DateHeureSoin.Date.CompareTo(deux.dateHeureSoin.Date);
            return date;
            // var date = DateTime.Compare(une.dateHeureSoin.Date, deux.dateHeureSoin.Date);
            //return date;
        }
        public int compareTo2(Prestations une)
        {
            var date = this.DateHeureSoin.Date.CompareTo(une.dateHeureSoin.Date);
            return date;
            // var date = DateTime.Compare(une.dateHeureSoin.Date, deux.dateHeureSoin.Date);
            //return date;
        }

        public override string ToString()
        {
            return "\tLibelle " + this.libelle + " - " + this.dateHeureSoin + " " + this.intervenant;
        }
    }
}
