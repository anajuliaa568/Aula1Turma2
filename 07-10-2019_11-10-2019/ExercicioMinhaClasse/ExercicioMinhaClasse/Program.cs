using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMinhaClasse
{
   public class Program
    {
        static void Main(string[] args)
        {
            var amigos02 = new List<Amigos>();

            amigos02.Add(new Amigos()
            {
                Nome = " Tamara ",
                tempoDeAmizade = 1,
                Nome2 = " Karine ",
                tempoDeAmizade2 = 2,
                Nome3 = " Ana Júlia ",
                tempoDeAmizade3 = 3

            }) ;

            amigos02.ForEach(i => Console.WriteLine($"Nome:{i.Nome}, tempo de amizade {i.tempoDeAmizade} " +
                $"Nome2:{i.Nome2}, tempo de amizade {i.tempoDeAmizade2}" +
                $" Nome3:{i.Nome3}, " +
                $"tempo de amizade: {i.tempoDeAmizade3}"));
            Console.ReadKey();
        }


    }
}
