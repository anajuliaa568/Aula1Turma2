using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificartamanhodonome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informar o nome a ser calculado: ");
            var nomeLenght = Console.ReadLine();

            Console.WriteLine($"O tamanho do nome é: {nomeLenght.Length}");
            Console.ReadKey();

        }
    }
}
