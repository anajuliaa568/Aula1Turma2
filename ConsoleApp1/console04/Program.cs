using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um texto:");
            var texto = Console.ReadLine();
            var cont = texto.Length;
            //length função contar os caracteres
            Console.WriteLine($"Quantidade de caracteres:{cont}");

            Console.ReadKey();
           
            
        }
    }
}
