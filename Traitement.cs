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
            try
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
                Console.WriteLine(dossier.ToString());
            }
            catch (SoinsException ex)
            {

                Console.WriteLine(ex.Message);
                Json.FichierJson(ex.Message);
            }

           

            //Teste date Presta
           
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
        internal static bool TesteDateCreationOk()
        {
            try
            {
                Dossier dossier = new Dossier("Dupont", "Jean", new DateTime(1990, 11, 12), new DateTime(2019, 3, 31));
                
                    return true;
                
                
            }
            catch(SoinsException ex)
            {
                return false;
            }
        }

        internal static bool TesteDateCreationKo()
        {
            try
            {
                Dossier dossier = new Dossier("Dupont", "Jean", new DateTime(1990, 11, 12), new DateTime(2030, 3, 31));
                return false;
            }
            catch(SoinsException ex)
            {
                return false;
            }
        }
        internal static bool TesteDatePrestationInferieurJourOK()
        {
            try
            {
                Intervenant DP = new Intervenant("Dupont", "Jean");
                IntervenantExterne DA = new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202");
                IntervenantExterne SO = new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303");
                Intervenant MJ = new Intervenant("Maurin", "Joëlle");
                Intervenant BM = new Intervenant("Blanchard", "Michel");
                Intervenant TH = new Intervenant("Tournier", "Hémène");

                Prestations p3 = new Prestations("P3", Convert.ToDateTime("10/13/2015 12:00:00"), DP);
                Prestations p1 = new Prestations("P1", Convert.ToDateTime("01/09/2015 12:00:00"), DA);
                Prestations p2 = new Prestations("P2", Convert.ToDateTime("08/09/2015 12:00:00"), SO);
                Prestations p4 = new Prestations("P4", Convert.ToDateTime("20/09/2015 12:00:00"), MJ);
                Prestations p6 = new Prestations("P6", Convert.ToDateTime("08/09/2015 09:00:00"), BM);
                Prestations p5 = new Prestations("P5", Convert.ToDateTime("10/09/2015 06:00:00"), TH);
                return true;              
            }
            catch(SoinsException ex)
            {
                return false;
            }

        }
        internal static bool TesteDatePrestationInferieurJourKO()
        {
            try
            {
                Intervenant DP = new Intervenant("Dupont", "Jean");
                IntervenantExterne DA = new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202");
                IntervenantExterne SO = new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303");
                Intervenant MJ = new Intervenant("Maurin", "Joëlle");
                Intervenant BM = new Intervenant("Blanchard", "Michel");
                Intervenant TH = new Intervenant("Tournier", "Hémène");

                Prestations p3 = new Prestations("P3", Convert.ToDateTime("30/13/2023 12:00:00"), DP);
                Prestations p1 = new Prestations("P1", Convert.ToDateTime("01/09/2023 12:00:00"), DA);
                Prestations p2 = new Prestations("P2", Convert.ToDateTime("08/09/2023 12:00:00"), SO);
                Prestations p4 = new Prestations("P4", Convert.ToDateTime("20/09/2015 12:00:00"), MJ);
                Prestations p6 = new Prestations("P6", Convert.ToDateTime("08/09/2015 09:00:00"), BM);
                Prestations p5 = new Prestations("P5", Convert.ToDateTime("10/09/2015 06:00:00"), TH);

                return false;
            }
            catch(SoinsException ex)
            {
                return true;
            }
        }

        internal static bool TesteDatePrestationSuperieurCreationOK()
        {
            try
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
                return true;
            }
            catch(SoinsException ex)
            {
                return false;
            }
        }

        internal static bool TesteDatePrestationSuperieurCreationKO()
        {
            try
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

                Dossier dossier = new Dossier("Robert", "Jean", Convert.ToDateTime("03/12/2021").Date, prestations);
                return false;
            }
            catch (SoinsException ex)
            {
                return true;
            }
        }

        }

 
    }


