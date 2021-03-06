using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaBoiteAOutils;
using ClassesMetier;
using Prestations_soins;

namespace soins
{
    class Program
    {
        static void Main()
        {           
            
            try
            {
                //Mise en page
                Traitement.TesteDossier();
                Console.WriteLine("Nb Prestations Intervenant : " + Traitement.TesteGetNbPrestationI());
                Console.WriteLine("Nb Prestations Intervenant Externe: " + Traitement.TesteGetNbPrestationIE());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               TempException = new Prestations_soins.Exceptions.TempException(ex);

                Console.ReadLine();
            }

            
        }
    }
}
