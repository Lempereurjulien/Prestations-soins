using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestations_soins
{
    class DirAppend
    {
        public static void TxtException(Exception ex)
        {
            using (StreamWriter w = File.AppendText("Except.txt"))
            {
                Log("\t" + ex.Message , w);               
            }
        
            using (StreamReader r = File.OpenText("Except.txt"))
            {
                DumpLog(r);
            }
        }
        public static void Log(string logMessage,TextWriter w)
            {
            w.Write("Exception : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");           
            w.WriteLine(logMessage);
            }

        public static void DumpLog(StreamReader r)
        {
            string line;
            while ((line = r.ReadLine()) == null)
            {
                Console.WriteLine("Le fichier Texte n'est pas crée");
            }
        }

    }
}
