using MinhaPrimeiraClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //criamos o nossao proprio tipo 
            var listaDeBicicleta = new List<Bicicleta>
            {
                new Bicicleta()
                {
                    Marca = "Monark"

                },
                new Bicicleta()
                {
                    Marca = "Caloi"
                }
            };
            listaDeBicicleta.ForEach(i => Console.WriteLine($"BikeOn > marca:{i.Marca} Pneus:{i.Pneus}"));
            Console.ReadKey();
        }

     
    }
                   
}

