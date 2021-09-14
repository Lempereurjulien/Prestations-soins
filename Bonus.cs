using ClassesMetier;
using MaBoiteAOutils;
using System;
using System.Collections.Generic;

namespace Soins2021
{
    static class Traitement
    {
        
        internal static void TesteDossierTrieDatePrestation()
        {
            List<Prestations> listePrestations = new List<Prestations>();
            Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3), listePrestations);

            // Les prestations sont triées par date
            Prestations P1 = new Prestations("Libelle P1", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"));
            unDossier.ajoutePrestations(P1);

            Prestations P2 = new Prestations("Libelle P2", new DateTime(2015, 9, 8, 12, 50, 0), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
            unDossier.ajoutePrestations(P2);

            Prestations P6 = new Prestations("Libelle P6", new DateTime(2015, 9, 8, 14, 30, 0), new Intervenant("Blanchard", "Michel"));
            unDossier.ajoutePrestations(P6);

            Prestations P3 = new Prestations("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.ajoutePrestations(P3);

            Prestations P3V2 = new Prestations("Libelle P3", new DateTime(2015, 9, 10, 16, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.ajoutePrestations(P3V2);

            Prestations P5 = new Prestations("Libelle P5", new DateTime(2015, 9, 10, 16, 30, 0), new Intervenant("Tournier", "Hélène"));
            unDossier.ajoutePrestations(P5);

            Prestations P4 = new Prestations("Libelle P4", new DateTime(2015, 9, 20, 12, 0, 0), new Intervenant("Maurin", "Joëlle"));
            unDossier.ajoutePrestations(P4);

            Prestations P4V2 = new Prestations("Libelle P4", new DateTime(2015, 9, 20, 12, 30, 0), new Intervenant("Maurin", "Joëlle"));
            unDossier.ajoutePrestations(P4V2);

            /*
             *  A Faire : Calculer er afficher le nombre de jours de prestations 
             *  en parcourant la liste des prestations triée sur les dates de prestations
             * 
             */

            
            
        }

        public static int getNbJourBonus(List<Prestations> actuelle)
        {
            DateTime comparatif = actuelle[0].DateHeureSoin.Date;
           int getNbJourBonus = 1;
            foreach(Prestations prestations in actuelle)
            {
                if(comparatif != prestations.DateHeureSoin.Date)
                {
                    getNbJourBonus++;
                    comparatif = prestations.DateHeureSoin.Date;
                }
            }
            return getNbJourBonus;
        }
        

        
    }
}