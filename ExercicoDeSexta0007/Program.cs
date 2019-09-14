using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoDeSexta0007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto: ");
            var texto = Console.ReadLine();

            string teste = texto;
            var count = teste.Split('a','e','i','o','u');

            Console.WriteLine(Convert.ToString(count.Length - 1));

            Console.ReadKey();
        }
    }
}
