﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesMetier;
using soins;


namespace MaBoiteAOutils
{
   public class Prestations
    {
        private string libelle;
        private DateTime dateHeureSoin;
        private Intervenant intervenant;
        private IntervenantExterne intervenantExterne;

        //Constructeur
        public Prestations(string libelle, DateTime dateHeureSoin,Intervenant intervenant)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
            this.intervenant = intervenant;
        }

        public Prestations(string libelle, DateTime dateHeureSoin, IntervenantExterne intervenantExterne)
        {
            this.libelle = libelle;
            this.dateHeureSoin = dateHeureSoin;
            this.intervenantExterne = intervenantExterne;
        }

        

        //Property
        public string Libelle { get => libelle;}
        public DateTime DateHeureSoin { get => dateHeureSoin;}
        public Intervenant Intervenant { get => intervenant; }
        public IntervenantExterne IntervenantExterne { get => intervenantExterne;}

        //Méthodes
        //Renvoi la date la plus vielle entre les 2 prestations
        public int CompareTo(Prestations une, Prestations deux)
        {
            var a = DateTime.Compare(une.dateHeureSoin, deux.dateHeureSoin);
            return a;
            // var date = DateTime.Compare(une.dateHeureSoin.Date, deux.dateHeureSoin.Date);
            //return date;
        }
        
    }
}
