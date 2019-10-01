using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSegundaClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            var MinhaCestaDeFrutas = new List<CestaDeFrutas1>();
            
               MinhaCestaDeFrutas.Add(new CestaDeFrutas1()
                {
                    Nome = "Banana",
                    Quantidade = 2
                              
                });

            MinhaCestaDeFrutas.ForEach(i => Console.WriteLine($"nome{i.Nome} Quant {i.Quantidade}"));
            Console.ReadKey();
                



            
                
        }
    }
}
