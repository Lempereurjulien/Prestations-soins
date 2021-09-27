using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestations_soins;
using MaBoiteAOutils;
using ClassesMetier;
using Prestations_soins.Exceptions;


namespace Soins2021
{
    public class SoinsException:Exception
    {
           //
        public SoinsException() { 
        }

        public SoinsException(string message) : base(message)
        {
        }
        
        //new SoinsException DateInferieurException("La date de prestations doit être postérieur à la date de création du dossier ");
    }
}
