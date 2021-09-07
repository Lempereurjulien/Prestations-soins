using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
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
        public string Libelle { get => libelle; set => libelle = value; }
        public DateTime DateHeureSoin { get => dateHeureSoin; set => dateHeureSoin = value; }
    }

    public void compareTo()
    {

    }
}
