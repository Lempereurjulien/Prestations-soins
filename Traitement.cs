using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBoiteAOutils;
using ClassesMetier;
using Soins2021;


namespace Prestations_soins
{

    static class Traitement
    {

        public static void TesteDossier()
        {
            Intervenant DP = new Intervenant("Dupont", "Jean");
            IntervenantExterne DA = new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202");
            IntervenantExterne SO = new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303");
            Intervenant MJ = new Intervenant("Maurin", "Joëlle");
            Intervenant BM = new Intervenant("Blanchard", "Michel");
            Intervenant TH = new Intervenant("Tournier", "Hémène");
            List<Prestations> prestations = new List<Prestations>();

            Prestations p3 = new Prestations("P3", Convert.ToDateTime("10/13/2015 12:00:00"), DP);
            Prestations p1 = new Prestations("P1", Convert.ToDateTime("01/09/2015 12:00:00"), DA);
            Prestations p2 = new Prestations("P2", Convert.ToDateTime("08/09/2015 12:00:00"), SO);
            Prestations p4 = new Prestations("P4", Convert.ToDateTime("20/09/2015 12:00:00"), MJ);
            Prestations p6 = new Prestations("P6", Convert.ToDateTime("08/09/2015 09:00:00"), BM);
            Prestations p5 = new Prestations("P5", Convert.ToDateTime("10/09/2015 06:00:00"), TH);



            prestations.Add(p3);
            prestations.Add(p1);
            prestations.Add(p2);
            prestations.Add(p4);
            prestations.Add(p6);
            prestations.Add(p5);
            





            Dossier dossier = new Dossier("Robert", "Jean", Convert.ToDateTime("03/12/1980").Date, prestations);

            //Teste date Presta
            foreach (Prestations presta in prestations)
            {
                try
                {
                    if (presta.DateHeureSoin > dossier.DateCreation)
                    {
                        throw new SoinsException(presta);
                    }
                }
                catch (SoinsException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            //

            //Teste Date Naissance Dossier
            if (dossier.DateNaissance > DateTime.Now)
            {
                throw new SoinsException(dossier);
                
            }
            //
            //Teste date prestation

            //Affichage
            Console.WriteLine(dossier.ToString());
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

