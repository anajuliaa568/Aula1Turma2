using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class MostrarListaCerveja
    {
        public static void ListaCervejas()
        {

          var lista = new List<string>();
            lista.Add("Skol");
            lista.Add("Antarctica");
            lista.Add("Original");
            lista.Add("Budweiser");

            lista.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }

    }
}
