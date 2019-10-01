using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeSexta03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            var nome = Console.ReadLine();
            
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"Parabéns {nome} você já esta na fase adulta.");
            else
                Console.WriteLine($"Calma {nome} tudo ao seu tempo logo você terá 18 anos de idade");

            //CW TAB TAB: VAIS MAIS RAPIDO
            //Quando if tiver apenas uma linha, não precisa de chaves. O else também
            

            Console.ReadKey();

        }
    }
}
