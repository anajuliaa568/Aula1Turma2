using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioDeSexta0005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a palavra:");
            var texto = Console.ReadLine();
            Console.WriteLine("O total de caracteres é {1}", texto, texto.Length);
            Console.ReadKey();
        }
    }
}
