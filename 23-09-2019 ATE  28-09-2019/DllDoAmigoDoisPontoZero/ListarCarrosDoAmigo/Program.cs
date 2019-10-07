using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController Controller = new CarroController();

        static void Main(string[] args)
        {
            Controller.GetSpecs().ForEach(i => Console.WriteLine($"{i.Id} {i.Marca} {i.Modelo}"));
            Console.ReadKey();
        }
    }
}
