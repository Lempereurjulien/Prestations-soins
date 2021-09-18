using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBoiteAOutils;
using ClassesMetier;


namespace Prestations_soins
{
    
     static class Traitement
    {
        
        public static void TesteDOssier(Dossier doss)
        {

            Console.WriteLine(doss.ToString());          
        }

        public static int TesteGetNbPrestationI()
        {
            Intervenant intervenantDP = new Intervenant("Dupont", "Jean");
            Prestations p3 = new Prestations("P3", Convert.ToDateTime("10/09/2015 12:00:00"), intervenantDP);
            Prestations p1 = new Prestations("P1", Convert.ToDateTime("01/09/2015 12:00:00"), intervenantDP);
            intervenantDP.ajoutePrestations(p3);
            intervenantDP.ajoutePrestations(p1);

            return intervenantDP.GetNbPrestation();
        }
        public static int TesteGetNbPrestationIE()
        {
            IntervenantExterne intervenantDA = new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "020202020202");
            Prestations p2 = new Prestations("P2", Convert.ToDateTime("08/09/2015 12:00:00"), intervenantDA);
            Prestations p4 = new Prestations("P4", Convert.ToDateTime("20/09/2015 12:00:00"), intervenantDA);
            Prestations p6 = new Prestations("P6", Convert.ToDateTime("08/09/2015 09:00:00"), intervenantDA);
            intervenantDA.ajoutePrestations(p2);
            intervenantDA.ajoutePrestations(p4);
            intervenantDA.ajoutePrestations(p6);

            return intervenantDA.GetNbPrestation();

        }
    }
}
