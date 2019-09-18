using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();

            string nome = string.Empty;
            int idade = 0;


            while (AskToContinue() == 1)
            {
                nome = AskToName();
                idade = AskToAge(nome);
                // sempre informa o comando para o AskToAge "informar uma string"

            }
            Console.WriteLine($"Suas informações: Nome {nome} e sua idade {idade} ");
            Console.ReadKey();
        }

        /// <summary>
        /// metodo para mostrr o texto inicial do sistema alone
        /// </summary>
        private static void ShowInitAppText()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("--Seja bem vindo--");
            Console.WriteLine("------------------");
        }

        /// <summary>
        /// metodo para realizar a pergunta se deseja continuar
        /// </summary>
        /// <returns></returns>
        private static int AskToContinue()
        {
            Console.WriteLine(" vamos conversar? sim(1) não(2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());


        }

        private static int AskToAge(string nome)
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"{nome} Bora beber caraiiiii sexxxxxxtouuuuuuu!!!!!");

            else
            {
                Console.WriteLine($" {nome} Tem leite na geladeira");
                Console.WriteLine($"Estou ligando para sua mãe");
            }
            // se colocar mais chaves {} vai ter que colocar mais informaçoes no else 
            // se queser colocar mais informaçoes é necessario criar uma string
            return idade;
        }


        private static string AskToName()
        {
            Console.WriteLine("Qual seu nome?");
            return Console.ReadLine();
        }




    }

}
