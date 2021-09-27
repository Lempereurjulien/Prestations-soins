using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soins2021;
using System.IO;
using Newtonsoft.Json;



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
        public static void TxtException(SoinsException ex)
        {
            using (StreamWriter w = File.AppendText("Except.json"))
            {
                Log("\t" + ex.Message, w);
            }

            using (StreamReader r = File.OpenText("Except.json"))
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

    class Json
    {
        public string Application { get; set; }
        public String ClasseException { get; set; }

        public DateTime DateException { get; set; }
        public String MessageException { get; set; }
        public string UserException { get; set; }
        public string UserMachine { get; set; }

        static JsonSerializer serializer;
        public static void FichierJson(string ex)
        {
            var Except = new Json
            {
               
                //Date = DateTime.Now,
                //Exception = ex
            };
            serializer = new JsonSerializer();
            string jsonString = JsonConvert.SerializeObject(Except,Formatting.Indented);
            var streamWriter = new StreamWriter("Except.json");

            var jsonWriter = new JsonTextWriter(streamWriter);

            jsonWriter.Formatting = Formatting.Indented;
            serializer.Serialize(jsonWriter, JsonConvert.DeserializeObject(jsonString));
            Console.WriteLine("Export ok");
        }
        
    }
}
 