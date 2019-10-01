using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDoNome16
{
    class Program
    {
        static void Main(string[] args)
        {
            var Informacao = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            var dadosPessoais = Informacao.Split(';');

                     

            foreach (var item in dadosPessoais)
            {
                Console.WriteLine(item.Split(',')[0]);
                
            }

            Console.WriteLine("informe a sua idade");

            var buscaIdade = Console.ReadLine();

            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
