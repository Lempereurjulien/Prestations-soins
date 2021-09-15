//using MaBoiteAOutils;
//using ClassesMetier;
//using System;

//namespace Soins2021
    
//{
//    static class Traitement
//    {
        
//        internal static void TesteDossierTrieDatePrestation()
//        {
//            Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3));

//            // Les prestations sont triées par date
//            Prestations p1 = new Prestations("Libelle P1", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Durand", "Annie", "Cardiologue", "Marseille", "0202020202"));
//            unDossier.ajoutePrestations(p1);

//            Prestations p2 = new Prestations("Libelle P2", new DateTime(2015, 9, 8, 12, 50, 0), new IntervenantExterne("Sainz", "Olivier", "Radiologue", "Toulon", "0303030303"));
//            unDossier.ajoutePrestations(p2);
//            unDossier.ajoutePrestations("Libelle P6", new DateTime(2015, 9, 8, 14, 30, 0), new Intervenant("Blanchard", "Michel"));
            
//            unDossier.ajoutePrestations("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
//            unDossier.ajoutePrestations("Libelle P3", new DateTime(2015, 9, 10, 16, 0, 0), new Intervenant("Dupont", "Jean"));
//            unDossier.ajoutePrestations("Libelle P5", new DateTime(2015, 9, 10, 16, 30, 0), new Intervenant("Tournier", "Hélène"));
            
//            unDossier.ajoutePrestations("Libelle P4", new DateTime(2015, 9, 20, 12, 0, 0), new Intervenant("Maurin", "Joëlle"));
//            unDossier.ajoutePrestations("Libelle P4", new DateTime(2015, 9, 20, 12, 30, 0), new Intervenant("Maurin", "Joëlle"));

//            /*
//             *  A Faire : Calculer er afficher le nombre de jours de prestations 
//             *  en parcourant la liste des prestations triée sur les dates de prestations
//             * 
//             */

//        }


//    }
//}