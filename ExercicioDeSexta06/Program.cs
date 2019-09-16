using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDeSexta06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite alguma coisa: ");
            var texto = Console.ReadLine();
            int quantidade = texto.Length;

            char primeira = ' ', ultima = ' ';

            int b = 0;
            for (int i = 0; i < quantidade; i++)
            {
                if (i == 0)
                {
                    primeira = texto[i];
                }
                b = i;
            }
            ultima = texto[b];
            Console.WriteLine($"A primeira letra é '{primeira}' e a ultima é: '{ultima}'");
            Console.ReadKey();

        }
    }
}
