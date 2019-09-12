using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoOFor
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = "Meu nome é Felipe Junior e minha mãe escolheu colocar junior em meu nome porque achava legal.";
            var countFind = 0;

            Console.WriteLine("Encontre a palavra de até 3 caracteres:");
            var palavra = Console.ReadLine();

            for (int i = 1; i < 11; i++)
                // diminuir um quando for avançando.
            {
                var stringBuilder = $"{nome[i - 1]} - {nome[i]}-{nome[i + 1]}";

                Console.WriteLine(stringBuilder);

                if (stringBuilder.Contains("u-n")) countFind++;
               
            }
            Console.WriteLine($"Quantidade total de 'um' {countFind}");

            Console.ReadKey();
        }
    }
}
