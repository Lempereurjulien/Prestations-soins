using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBoiteAOutils;
using ClassesMetier;

namespace soins
{
    class Program
    {
        static void Main()
        {
            //Dossier
            var dateRJ = new DateTime(1980, 12, 3);
            List<Prestations> listePrestation = new List<Prestations>();
            Dossier RJ = new Dossier("Robert", "Jean", dateRJ, listePrestation);
            

            //1 prestation
            Intervenant DJ = new Intervenant("Dupont", "Jean");
            var dateP3=new DateTime(2015, 9, 10, 12, 0, 0);
            Prestations P3 = new Prestations("P3", dateP3,DJ);
            RJ.ajoutePrestations(P3);

            //2 prestation
            IntervenantExterne DA = new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202");
            var dateP1 = new DateTime(2015, 9, 1, 12, 0, 0);
            Prestations P1 = new Prestations("P1", dateP1, DA);
            RJ.ajoutePrestations(P1);

            //3 prestation
            IntervenantExterne SO = new IntervenantExterne("Sainz", "Olivier", "Radiologue","Toulon","0303030303");
            var dateP2 = new DateTime(2015, 9, 8, 12, 0, 0);
            Prestations P2 = new Prestations("P2", dateP2, SO);
            RJ.ajoutePrestations(P2);

            //4 prestation
            Intervenant MJ = new Intervenant("Maurin", "Joëlle");
            var dateP4 = new DateTime(2015, 9, 20, 12, 0, 0);
            Prestations P4 = new Prestations("P4", dateP4, MJ);
            RJ.ajoutePrestations(P4);

            //5 prestation
            Intervenant BM = new Intervenant("Blanchard", "Michel");
            var dateP6 = new DateTime(2015, 9, 8, 9, 0, 0);
            Prestations P6 = new Prestations("P6", dateP6, BM);
            RJ.ajoutePrestations(P6);

            //6 prestation
            Intervenant TH = new Intervenant("Tournier", "Hélène");
            var dateP5 = new DateTime(2015, 9, 10, 6, 0, 0);
            Prestations P5 = new Prestations("P5", dateP5, TH);
            RJ.ajoutePrestations(P5);

            //Mise en page
            Console.WriteLine("-----Début de dossier-----");

            Console.WriteLine("Nom :" + RJ.Nom + " Prenom : " + RJ.Prenom + " Date de naissance: " + RJ.DateNaissance.Date);
            //1 libelle
            Console.WriteLine("         Libelle " + listePrestation[0].Libelle + " - " + listePrestation[0].DateHeureSoin +
                " - Intervenant : " + listePrestation[0].Intervenant.Nom + " - " + listePrestation[0].Intervenant.Prenom);
            //2 libelle 
            Console.WriteLine("         Libelle " + listePrestation[1].Libelle + " - " + listePrestation[1].DateHeureSoin +
                " - Intervant : " + listePrestation[1].IntervenantExterne.Nom + " - " + listePrestation[1].IntervenantExterne.Prenom +
                " Spécialité : " + listePrestation[1].IntervenantExterne.Specialite + " " + listePrestation[1].IntervenantExterne.Adresse +
                " - " + listePrestation[1].IntervenantExterne.Tel);
            //3 libelle 
            Console.WriteLine("         Libelle " + listePrestation[2].Libelle + " - " + listePrestation[2].DateHeureSoin +
                " - Intervant : " + listePrestation[2].IntervenantExterne.Nom + " - " + listePrestation[2].IntervenantExterne.Prenom +
                " Spécialité : " + listePrestation[2].IntervenantExterne.Specialite + " " + listePrestation[2].IntervenantExterne.Adresse +
                " - " + listePrestation[2].IntervenantExterne.Tel);
            //4 libelle 
            Console.WriteLine("         Libelle " + listePrestation[3].Libelle + " - " + listePrestation[3].DateHeureSoin +
               " - Intervenant : " + listePrestation[3].Intervenant.Nom + " - " + listePrestation[3].Intervenant.Prenom);
            //5 libelle
            Console.WriteLine("         Libelle " + listePrestation[4].Libelle + " - " + listePrestation[4].DateHeureSoin +
               " - Intervenant : " + listePrestation[4].Intervenant.Nom + " - " + listePrestation[4].Intervenant.Prenom);
            //6 libelle 
            Console.WriteLine("         Libelle " + listePrestation[5].Libelle + " - " + listePrestation[5].DateHeureSoin +
               " - Intervenant : " + listePrestation[5].Intervenant.Nom + " - " + listePrestation[5].Intervenant.Prenom);
            
            Console.WriteLine("-----Fin dossier--------");
            Console.WriteLine("Nombre de jours de soins V1 : " + RJ.getNbJoursSoins(RJ));
            Console.WriteLine("Nombre de jours de soins V2 : " + RJ.getNbjoursSoinsV2(RJ));
            Console.WriteLine("Nombre de soins externes : " + RJ.getNbPrestationsExternes(RJ));
            Console.ReadLine();
        }
    }
}
