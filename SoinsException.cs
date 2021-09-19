using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestations_soins;
using MaBoiteAOutils;
using ClassesMetier;


namespace Soins2021
{
    public class SoinsException:Exception
    {
           //
        public SoinsException() { 
        }

        public SoinsException(Dossier dossier) : base(string.Format("La date de naissance du dossier {0} ne peut pas être inférieur à celle du jour", dossier))
        {

        }
        public SoinsException(Prestations presta) : base(string.Format("La date de prestationdoit être postérieure à la date de création du dossier"))
        {

        }

        //new SoinsException DateInferieurException("La date de prestations doit être postérieur à la date de création du dossier ");
    }
}
