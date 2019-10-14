using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flores.Controller;
using Flores.Model;

namespace FloriculturaListagem
{
    public class Program
    {
        static FloresController flores = new FloresController();
        static void Main(string[] args)
        {
            MostrarMenu();

        }

        public static void MostrarMenu()
        {
            var menuFlores = 0;

            while (menuFlores == 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir uma flor ");
                Console.WriteLine("2 - Listar Flores");
                menuFlores = int.Parse(Console.ReadLine());
            }


            switch (menuFlores)
            {
                case 1:
                    InserirFlores();
                    break;

                case 2:
                    Listarflores();
                    break;

                default:
                    break;

            }

        }


        static public void InserirFlores()
        {
            Console.WriteLine("---Inserir flores---");
            Console.WriteLine("Informe o nome da flor");

            
            var nomeflor = Console.ReadLine(); //obtemos o nome da flor 

            var resultado = flores.InserirFlor(new Flor()
            {
                Nome = nomeflor
            });

            if (resultado)
                Console.WriteLine("Flor cadastrada com sucesso :)");
            else
                Console.WriteLine("Erro no cadastrar flor :(");

            Console.ReadKey();

        }

        static public void Listarflores()
        {
            Console.WriteLine("---Lista de flores---");
            flores.GetFlores().OrderByDescending(p => p.Quantidade).ToList().
                ForEach(i => Console.WriteLine($"Id: {i.Id} Flor: {i.Nome} Quantidade: {i.Quantidade}"));

            Console.WriteLine(flores.RetornarTotalQuantidadeFlores());

            Console.ReadKey(true);
        }

    }
}





