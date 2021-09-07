﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
      class IntervenantExterne :Intervenant()
    {     
        private string specialite;
        private string adresse;
        private string tel;

        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel):base(nom, prenom)
        {           
            this.specialite = specialite;
            this.adresse = adresse;
            this.tel = tel;
        }
    }
}