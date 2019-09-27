using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCeverjas.Controller;

namespace testecerveja
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Cervejas:");
            cervejaController.GetCervejas().ForEach(x => Console.WriteLine($"Id: {x.Id } Nome: {x.Nome} Litros: {x.Litros} Alcool: {x.Alcool} Valor: {x.Valor}"));
            Console.WriteLine("");
            Console.ReadKey();
            
            Console.WriteLine($"Total Valor: {cervejaController.RetornarValor()}");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine($"Total Litros: {cervejaController.RetornarLitros()}");
            Console.ReadKey();
        }
    }
}
