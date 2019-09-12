using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // texto informativo para consultar o livro
            // pelo numero de registro do livro
           Console.WriteLine("Informe o livro a ser consultado:");
            // parte do codigo que recebe as informações 
            // de registro do livro e coloca na varavel 
            // numeroDoLivro para utilizar
            var numeroDoLivro = Console.ReadLine();
            // Aqui realizo a comparação das informações 
            // do livro informado com o que tenho disponivel 
            // em estoque 
            if (numeroDoLivro == "123456")
            {
                // informo que este livro já está alocado
                Console.WriteLine("Livro Indisponivel!!!"); 
                 Console.ReadKey();
                //Finaliza o metodo 
                return;
            }
            else 
            {
                Console.WriteLine("Deseja alocar o Livro? (1)sim (2)não");
                var resposta = Console.ReadLine();
                if(resposta == "1")
                { 
                    Console.WriteLine("Livro alocado");
                    Console.ReadKey();
                }
            }
        }
    }
}
