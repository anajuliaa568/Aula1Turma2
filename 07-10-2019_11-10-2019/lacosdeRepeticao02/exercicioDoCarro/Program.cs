using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioDoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            var conteudo = "nome:honda,marca:civic,ano:2018;nome:gol,marca:volkswagen,ano:2000";

            var informacaoDoCarro = conteudo.Split(';');

            Console.WriteLine("carros cadastrados");

            foreach (var item in informacaoDoCarro)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("informe o nome do carro no sistema:");
            var carrobusca = Console.ReadLine();


            foreach (var item in informacaoDoCarro)
            {
                var informacaoDoCarroSplit = item.Split(',');

                var nome = informacaoDoCarroSplit[0].Split(':')[1];
                var marca = informacaoDoCarroSplit[1].Split(':')[1];
                var ano = informacaoDoCarroSplit[2].Split(':')[1];

                if (nome == carrobusca)
                {
                    Console.WriteLine($"{nome} da {marca} é do ano {ano}.");

                }
            }

            Console.ReadKey();
        }
    }
}
