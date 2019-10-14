using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoExercicioPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeInformacao = new List<Pessoas>
            {
                new Pessoas()
                {
                    Id = 1,
                    Nome = "Spears",
                    DataNascimento = DateTime.Parse("11/09/2011"),
                    Carteira = 846.96

                },
                new Pessoas()
                {
                    Id = 2,
                    Nome = "Swanson",
                    DataNascimento = DateTime.Parse("20/06/2003"),
                    Carteira = 233.09

                },
                new Pessoas()
                {
                    Id = 3,
                    Nome = "Gay",
                    DataNascimento = DateTime.Parse("03/12/2001"),
                    Carteira = 911.92

                },
                new Pessoas()
                {
                    Id = 4,
                    Nome = "Gregory",
                    DataNascimento = DateTime.Parse("02/01/2000"),
                    Carteira = 469.01

                },
                new Pessoas()
                {
                    Id = 5,
                    Nome = "Olson",
                    DataNascimento = DateTime.Parse("18/07/2001"),
                    Carteira = 261.90

                },
                new Pessoas()
                {
                    Id = 6,
                    Nome = "Garza",
                    DataNascimento = DateTime.Parse("01/04/2000"),
                    Carteira = 360.41

                },
                new Pessoas()
                {
                    Id = 7,
                    Nome = "Sweet",
                    DataNascimento = DateTime.Parse("12/03/2003"),
                    Carteira = 312.76

                },
                new Pessoas()
                {
                    Id = 8,
                    Nome = "Cline",
                    DataNascimento = DateTime.Parse("26/03/2002"),
                    Carteira = 484.51

                },
                new Pessoas()
                {
                    Id = 9,
                    Nome = "Oliver",
                    DataNascimento = DateTime.Parse("05/07/2004"),
                    Carteira = 513.76

                },
                new Pessoas()
                {
                    Id = 10,
                    Nome = "Vang",
                    DataNascimento = DateTime.Parse("10/07/2000"),
                    Carteira = 271.05

                },
                new Pessoas()
                {
                    Id = 11,
                    Nome = "Maddox",
                    DataNascimento= DateTime.Parse("29/05/2004"),
                    Carteira =  783.97
                },
                 new Pessoas()
                {
                    Id = 12,
                    Nome = "Garrett",
                    DataNascimento= DateTime.Parse("03/06/2006"),
                    Carteira =   154.11
                },
                 new Pessoas()
                {
                    Id = 13,
                    Nome = "Mcintosh",
                    DataNascimento= DateTime.Parse("06/07/2006"),
                    Carteira = 902.80
                },
                 new Pessoas()
                {
                    Id = 14,
                    Nome = "Yang",
                    DataNascimento= DateTime.Parse("29/04/2005"),
                    Carteira =  550.48
                },
                 new Pessoas()
                {
                    Id = 15,
                    Nome = "Hendricks",
                    DataNascimento= DateTime.Parse("05/09/2003	"),
                    Carteira =410.56
                },
                  new Pessoas()
                {
                    Id = 16,
                    Nome = "Cain",
                    DataNascimento= DateTime.Parse("12/01/2002	"),
                    Carteira =221.13
                },
                    new Pessoas()
                {
                    Id = 17,
                    Nome = "Blackburn",
                    DataNascimento= DateTime.Parse("10/05/2000	"),
                    Carteira =135.67
                },
                     new Pessoas()
                {
                    Id = 18,
                    Nome = "Howe",
                    DataNascimento= DateTime.Parse("27/09/2005"),
                    Carteira = 360.14
                },
                      new Pessoas()
                {
                    Id = 19,
                    Nome = "Pratt",
                    DataNascimento= DateTime.Parse("18/09/2000"),
                    Carteira =  991.83
                },
                         new Pessoas()
                {
                    Id = 20,
                    Nome = "Sherman",
                    DataNascimento= DateTime.Parse("20/02/2003"),
                    Carteira =  667.00
                },
            };

            Console.WriteLine("*********************DATA DE NASCIMENTO*********************\r\n");
            listaDeInformacao
                .OrderByDescending(x => x.DataNascimento)
                .ToList<Pessoas>()
                .ForEach(i => Console.WriteLine($"Id: {i.Id} Nome: {i.Nome} Data Nascimento {i.DataNascimento}"));
            Console.WriteLine("");

            Console.WriteLine("*********************ORDENANDO NOME*********************\r\n");
            listaDeInformacao
                .OrderBy(x => x.Nome)
                .ToList<Pessoas>()
                .ForEach(i => Console
                .WriteLine($"Id: {i.Id} Nome: {i.Nome} Data Nascimento {i.DataNascimento}"));
            Console.WriteLine("");

            Console.WriteLine("*********************ORDENANDO POR MAIS DE R$500*********************\r\n");


            var filtroPessoas = listaDeInformacao.Where(x => x.Carteira > 500).OrderBy(i => i.Nome);
            filtroPessoas.ToList<Pessoas>().ForEach(i => Console.WriteLine($"Id {i.Id} Nome: {i.Nome} Carteira: {i.Carteira}"));
            Console.WriteLine("");
            Console.WriteLine("*********************ORDENANDO POR MAIORES DE 18*********************\r\n");

            //RETORNA  MAIORES DE 18
            var maiorIdade = listaDeInformacao.FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) >= 18).OrderBy(i=> i.DataNascimento);
            maiorIdade.ToList<Pessoas>().ForEach(i => Console.WriteLine($"Nome {i.Nome} Idade {i.DataNascimento}"));
            Console.WriteLine("");
            Console.WriteLine("*********************ORDENANDO POR MENORES DE 16*********************\r\n");

            //RETORNA MENORES DE 16
            var menosIdade = listaDeInformacao.FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) <= 16).OrderBy(i => i.DataNascimento);
            menosIdade.ToList<Pessoas>().ForEach(i => Console.WriteLine($"Nome {i.Nome} Idade {i.DataNascimento}"));
            Console.WriteLine("");
            Console.WriteLine("*********************ORDENANDO POR MES ESPECIFICO*********************\r\n");

            //RETORNA NASCIDOS EM UM MES ESPECIFICO
            var mesNascimento = listaDeInformacao.Where(x => x.DataNascimento.Month == 09).OrderBy(i => i.DataNascimento);
            mesNascimento.ToList<Pessoas>().ForEach(i => Console.WriteLine($"Nome {i.Nome} Idade {i.DataNascimento}"));

            Console.ReadKey();

        }

        //private static object ToList<T>()
        //{
        //    throw new NotImplementedException();
        //}

    }
}