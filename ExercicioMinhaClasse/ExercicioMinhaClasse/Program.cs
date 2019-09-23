using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMinhaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var amigos02 = new List<Amigos>();

            amigos02.Add(new Amigos()
            {
                Nome = " Marlon",
                tempoDeAmizade = 3,
                Nome2 = " Karla",
                tempoDeAmizade2 = 10,
                Nome3 = " kate",
                tempoDeAmizade3 = 1

            }) ;

            amigos02.ForEach(i => Console.WriteLine($"Nome:{i.Nome}, tempo de amizade {i.tempoDeAmizade} " +
                $"Nome2:{i.Nome2}, tempo de amizade {i.tempoDeAmizade2}" +
                $" Nome3:{i.Nome3}, " +
                $"tempo de amizade: {i.tempoDeAmizade3}"));
            Console.ReadKey();
        }


    }
}
