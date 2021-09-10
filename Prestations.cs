using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using soins;


namespace MaBoiteAOutils
{
    class Prestations
    {
        private string libelle;
        private DateTime dateHeureSoin;
        

        //Constructeur
        public Prestations(string libelle, DateTime dateHeureSoin)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
        }

        //Property
        public string Libelle { get => libelle;}
        public DateTime DateHeureSoin { get => dateHeureSoin;}

        //Méthodes
        //Renvoi la date la plus vielle entre les 2 prestations
        public int compareTo(Prestations une, Prestations deux)
        {
             return DateTime.Compare(une.dateHeureSoin.Date, deux.dateHeureSoin.Date);                       
        }
    }
}
