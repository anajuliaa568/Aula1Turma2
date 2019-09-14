using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioDeSexta04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a palavra:");
            var texto = Console.ReadLine();
            string correctString = texto.Replace("banana", "laranja");
           
            Console.WriteLine(correctString);
            Console.ReadKey();
        }
    }
}
