using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
   public class MostrarListas
    {
        
        public static void MarcaCarros()
        {

            var lista = new List<string>();
            lista.Add("Ferrari");
            lista.Add("Fiat");
            lista.Add("Toyota");
            lista.Add("Honda");
            lista.Add("Dodge");

            lista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}
