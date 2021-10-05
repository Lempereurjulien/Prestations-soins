using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prestations_soins.Exceptions
{
     internal class TempException
    {
      
        public string Application { get; set; }
        public string ClasseException { get; set; }
        public DateTime DateException { get;set; }
        public string MessageException { get; set; }
        public string UserException { get; set; }
        public string UserMachine { get; set; }

        public JsonSerializer serializer { get; set; }
        public TempException(Soins2021.SoinsException ex)
        {
            Application = "Application :" ;
            ClasseException = "Classe Exception :";
            DateException = DateTime.Now;
            MessageException = ex.Message;
            UserException = "userException";
            UserMachine = "userMachine";
            
             
        }

        public void EcritJson() {
            string jsonString = (JsonConvert.SerializeObject(Formatting.Indented));
            var streamwriter = new StreamWriter(@"C: \Users\33610\Documents\Julien\BTS\ROCHE\C#\Bts 2eme anné\Prestations soins\ExceptionData.json");
            Console.WriteLine(jsonString);
        }

    }
}
