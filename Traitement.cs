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
        public static void TesteDOssier(Dossier doss, List<Prestations> listePresta)
        {
            

            Console.WriteLine("-----Début de dossier-----");

            Console.WriteLine("Nom :" + doss.Nom + " Prenom : " + doss.Prenom + " Date de naissance: " + doss.DateNaissance.ToString("d"));
            //1 libelle
            Console.WriteLine("         Libelle " + listePresta[0].Libelle + " - " + listePresta[0].DateHeureSoin +
                " - Intervenant : " + listePresta[0].Intervenant.Nom + " - " + listePresta[0].Intervenant.Prenom);
            //2 libelle 
            Console.WriteLine("         Libelle " + listePresta[1].Libelle + " - " + listePresta[1].DateHeureSoin +
                " - Intervant : " + listePresta[1].IntervenantExterne.Nom + " - " + listePresta[1].IntervenantExterne.Prenom +
                " Spécialité : " + listePresta[1].IntervenantExterne.Specialite + " " + listePresta[1].IntervenantExterne.Adresse +
                " - " + listePresta[1].IntervenantExterne.Tel);
            //3 libelle 
            Console.WriteLine("         Libelle " + listePresta[2].Libelle + " - " + listePresta[2].DateHeureSoin +
                " - Intervant : " + listePresta[2].IntervenantExterne.Nom + " - " + listePresta[2].IntervenantExterne.Prenom +
                " Spécialité : " + listePresta[2].IntervenantExterne.Specialite + " " + listePresta[2].IntervenantExterne.Adresse +
                " - " + listePresta[2].IntervenantExterne.Tel);
            //4 libelle 
            Console.WriteLine("         Libelle " + listePresta[3].Libelle + " - " + listePresta[3].DateHeureSoin +
               " - Intervenant : " + listePresta[3].Intervenant.Nom + " - " + listePresta[3].Intervenant.Prenom);
            //5 libelle
            Console.WriteLine("         Libelle " + listePresta[4].Libelle + " - " + listePresta[4].DateHeureSoin +
               " - Intervenant : " + listePresta[4].Intervenant.Nom + " - " + listePresta[4].Intervenant.Prenom);
            //6 libelle 
            Console.WriteLine("         Libelle " + listePresta[5].Libelle + " - " + listePresta[5].DateHeureSoin +
               " - Intervenant : " + listePresta[5].Intervenant.Nom + " - " + listePresta[5].Intervenant.Prenom);

            Console.WriteLine("-----Fin dossier--------");
            Console.WriteLine("Nombre de jours de soins V1 : " + doss.getNbJoursSoins(doss));
            Console.WriteLine("Nombre de jours de soins V2 : " + doss.getNbjoursSoinsV2(doss));
            Console.WriteLine("Nombre de soins externes : " + doss.getNbPrestationsExternes(doss));
            Console.ReadLine();
        }
    }
}
