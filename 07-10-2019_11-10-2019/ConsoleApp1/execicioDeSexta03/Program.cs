using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execicioDeSexta03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome:");
            string nome = string.Empty;
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua idade:");

            int idade = 0;
            idade = int.Parse(Console.ReadLine());
            

            if (idade >= 18)
            {
                Console.WriteLine($"Parabéns { nome} você já esta na fase adulta.");

            }
            else
            {
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade.");

            }
            Console.ReadKey();





        }

    }
}
