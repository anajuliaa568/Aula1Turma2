using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a palavra:");
            var palavra = Console.ReadLine();
            var tamanho = palavra.Length;
            var primeira = palavra[0];
            var ultima = palavra[tamanho-1];
            Console.WriteLine($"primeira: {primeira} e ultima:" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $"" +
                $" {ultima}");
            Console.ReadKey();
        }

    }
}
