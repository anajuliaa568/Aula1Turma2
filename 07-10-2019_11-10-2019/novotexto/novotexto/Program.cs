using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novotexto
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeiroTexto = "Olá Priscila Gomes, espero que tenha um ótimo dia Priscila Gomes, de trabalho, Priscilla Gomes, com muitas atividades divertidas para alegrar o seu dia Priscilla Gomes, espero que tudo de certo...";
           
            primeiroTexto = primeiroTexto.Replace("Priscila", "1").Replace("Gomes", "2");

            Console.WriteLine($"Texto contém: {primeiroTexto.Length} cacteres.");

            Console.ReadKey();
        }
    }
}
