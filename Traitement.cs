using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBoiteAOutils;
using ClassesMetier;


namespace Prestations_soins
{
    public static class Traitement
    {



       public static void TesteDOssier(Dossier doss)
        {


            List<Prestations> listePresta = new ;

            Console.WriteLine("-----Début de dossier-----");

            Console.WriteLine("Nom :" + doss.Nom + " Prenom : " + doss.Prenom + " Date de naissance: " + doss.DateNaissance.ToString("d"));
            //1 libelle
            Console.WriteLine("         Libelle " + doss.[0].Libelle + " - " + listePrestation[0].DateHeureSoin +
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
            Console.WriteLine("Nombre de jours de soins V1 : " + doss.getNbJoursSoins(doss));
            Console.WriteLine("Nombre de jours de soins V2 : " + doss.getNbjoursSoinsV2(doss));
            Console.WriteLine("Nombre de soins externes : " + doss.getNbPrestationsExternes(doss));
            Console.ReadLine();
        }
    }
}
