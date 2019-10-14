using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioDeSexta
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("informe Seu Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");

            int idade = int.Parse(Console.ReadLine());
  

            Console.WriteLine($"informação: {nome} e sua idade {idade} ");
            Console.ReadKey();

            // execicio 1 e 2
        }   
       

    }
}
