using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicioDoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            ForeachComSplit();
        }

        private static void IniciandoForEach1()
        {
            Console.WriteLine("informar o texto");
            var conteudoDoTexto = Console.ReadLine();

            foreach (var item in conteudoDoTexto)
            {
                if (item == 'e')
                    continue;
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
        /// <summary>
        /// Metodo de busca com split e informando o nome 
        /// </summary>
        private static void ForeachComSplit()
        {
            var conteudoDoTexto = "aqui vou colocar meu nome priscilla para realizar a busca";

            Console.WriteLine("Informe a palavra para realizar a busca:");
            var palavra = Console.ReadLine();

            var conteudoDoTextoSplit = conteudoDoTexto.Split(' ');

            foreach (var item in conteudoDoTextoSplit)
            {
                if (palavra == item)
                {
                    Console.WriteLine("Palavra encontrada com sucesso");

                }
                
            }
           Console.ReadKey();
        }
    }
}
